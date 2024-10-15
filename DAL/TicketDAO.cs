using Model;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
