using System;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using System.Security.Cryptography;
using Model.Enums;

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
            { //Get all users
                users.Add(new User(document));
            }
            return users;
        }

        public void CreateUser(User user)
        {
            user.Password = HashPassword(user.Password);

            var userDocument = new BsonDocument
            {
                { "_id", ObjectId.GenerateNewId() },               
                { "last_name", user.Last_Name },                  
                { "first_name", user.First_Name },                 
                { "username", user.Username },                     
                { "password", user.Password },                    
                { "role", user.Role.ToString() },                 
                { "email", user.Email }                            
            };

            IMongoCollection<BsonDocument> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<BsonDocument>("User");
            collection.InsertOne(userDocument);
        }



        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                // Convert the byte array to a string
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public void DeleteUser(ObjectId id)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            collection.DeleteOne(filter);
        }

        public void UpdateUser(User user)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", user.Id);
            var update = Builders<BsonDocument>.Update
                .Set("first_name", user.First_Name)
                .Set("last_name", user.Last_Name)
                .Set("email", user.Email)
                .Set("role", user.Role);

            collection.UpdateOne(filter, update);
        }
    }
}
