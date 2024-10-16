using System;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
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
            { //Get all users
                users.Add(new User(document));
            }
            return users;
        }
        public User ValidateUserCredentials(string username, string password)
        {
            IMongoCollection<BsonDocument> collection = this.READCollection("User");
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.And(
                Builders<BsonDocument>.Filter.Eq("username", username),
                Builders<BsonDocument>.Filter.Eq("password", password) // This would ideally be hashed
            );
            BsonDocument document = collection.Find(filter).FirstOrDefault();

            if (document == null)
            {
                return null; // Invalid credentials
            }
            return new User(document);
        }
    }
}
