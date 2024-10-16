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
        public ObjectId Reporter_id { get; set; }
        public Enums.Status Status { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Enums.Priority Priority { get; set; }
        public Ticket(BsonDocument document)
        {
            this.Id = (ObjectId)document["_id"];
            this.Title = (string)document["Title"];
            this.Description = (string)document["Description"];
            this.Reporter_id = (ObjectId)document["Reporter_id"];
            this.Status = (Status)(int)document["Status"];
            this.Start_Date = (DateTime)document["Start_Date"];
            if (document["End_Date"] != null)
            {
                //this.End_Date = (DateTime)document["end_date"];
            }
        }

        public Ticket(string title, string description, ObjectId reporter_id, Status status, DateTime start_Date, DateTime end_Date, Priority priority)
        {
            this.Title = title;
            this.Description = description;
            this.Reporter_id = reporter_id;
            this.Status = status;
            this.Start_Date = start_Date;
            this.End_Date = end_Date;
            this.Priority = priority;
        }
    }
}
