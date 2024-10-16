using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class TicketDAO : BaseDao
    {
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            IMongoCollection<BsonDocument> collection = this.READCollection("Tickets");
            foreach (BsonDocument document in collection.Find(_ => true).ToListAsync().Result)
            { //Get all tickets
                tickets.Add(new Ticket(document));
            }
            return tickets;
        }
        public List<Ticket> GetTicketsFromSearchQuery(string query)
        {
            List<Ticket> tickets = new List<Ticket>();
            IMongoCollection<BsonDocument> collection = this.READCollection("Tickets");
            foreach (BsonDocument document in collection.Find(_ => true).ToListAsync().Result)
            { //Get all tickets
                tickets.Add(new Ticket(document));
            }
            return tickets;
        }

        public void CreateNewTicket(Ticket ticket)
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            collection.InsertOne(ticket);
        }
    }
}
