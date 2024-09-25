using System;
using Model;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

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
    }
}
