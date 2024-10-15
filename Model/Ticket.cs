using Model.Enums;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ticket
    {
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int User_id { get; set; }
        public Enums.Status Status { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Enums.Priority Priority { get; set; }
        public Ticket(BsonDocument document)
        {
            this.Id = (ObjectId)document["_id"];
            this.Title = (string)document["title"];
            this.Description = (string)document["description"];
            this.User_id = (int)document["user_id"];
            this.Status = (Status)Enum.Parse(typeof(Status), (string)document["status"]);
            this.Start_Date = (DateTime)document["start_date"];
            if (document["end_date"] != null)
            {
                //this.End_Date = (DateTime)document["end_date"];
            }
        }
    }
}
