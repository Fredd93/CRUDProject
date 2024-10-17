using System;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Text.Json;


namespace DAL
{
    public class UserDAO : BaseDao
    {
        public User READUser(string firstname)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("first_name", firstname);
            BsonDocument document = collection.Find(filter).First();
            return new User(document);
        }

        public User READUserByUsername(string username)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);
            BsonDocument document = collection.Find(filter).FirstOrDefault();
            if (document == null)
            {
                return null;
            }
            return new User(document);
        }

        public User GetUserById(ObjectId id)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            BsonDocument document = collection.Find(filter).First();
            return new User(document);
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            foreach (BsonDocument document in collection.Find(_ => true).ToListAsync().Result)
            {
                users.Add(new User(document));
            }
            return users;
        }

        public User ValidateUserCredentials(string username, string password)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");

            // Hash the entered password to compare it with the stored hashed password
            string hashedPassword = HashPassword(password);

            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("username", username),
                Builders<BsonDocument>.Filter.Eq("password", hashedPassword)  // Compare hashed values
            );

            BsonDocument document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                return null; // Invalid credentials
            }
            return new User(document); // Return the User object if credentials are valid
        }

        // HashPassword method (this should already exist in your service layer)
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Compute the hash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        public void UpdateUserPassword(string username, string hashedPassword)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);

            // Define the update (set the new password)
            var update = Builders<BsonDocument>.Update.Set("password", hashedPassword);

            // Apply the update
            collection.UpdateOne(filter, update);
        }


        // Store the reset token and its expiration date
        public void StoreResetToken(string username, string token)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);

            // Set the token and expiration (24 hours from now)
            var update = Builders<BsonDocument>.Update
                .Set("reset_token", token)
                .Set("token_expiration", DateTime.UtcNow.AddHours(24));

            collection.UpdateOne(filter, update);
        }

        // Get the username by token
        public User GetUsernameByToken(string token)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("reset_token", token);
            BsonDocument document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                return new User(document);  // Return the full user object
            }

            return null; // Token not found or invalid
        }


        // Verify if the token is valid and not expired
        public bool VerifyResetToken(string username, string token)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);
            BsonDocument document = collection.Find(filter).FirstOrDefault();

            if (document != null && document.Contains("reset_token") && document["reset_token"] == token)
            {
                // Check if the token is expired
                DateTime expiration = document["token_expiration"].ToUniversalTime();
                if (DateTime.UtcNow <= expiration)
                {
                    return true; // Token is valid and not expired
                }
            }

            return false; // Token is invalid or expired
        }

        // Method to clear the reset token and expiration after successful password reset
        public void ClearResetToken(string username)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Eq("username", username);

            // Define the update (clear the token and expiration)
            var update = Builders<BsonDocument>.Update
                .Set("reset_token", "")
                .Set("token_expiration", BsonNull.Value);

            // Apply the update
            collection.UpdateOne(filter, update);
        }

    }
}
