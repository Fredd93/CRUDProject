using MongoDB.Driver;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Roles Role { get; set; }
        public User(BsonDocument document)
        {
            this.Id = (ObjectId)document["_id"];
            this.First_Name = (string)document["first_name"];
            this.Last_Name = (string)document["last_name"];
            this.Username = (string)document["username"];
            this.Password = (string)document["password"];
            this.Email = (string)document["email"];
            this.Role = (Roles)Enum.Parse(typeof(Roles), (string)document["role"]);
        }
    }
}
