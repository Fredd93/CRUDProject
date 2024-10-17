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
        IMongoCollection<BsonDocument> collection;
        public TicketDAO() 
        {
            collection = this.READCollection("Tickets");
        }
        public List<Ticket> GetAllTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            foreach (BsonDocument document in collection.Find(_ => true).Limit(50).ToListAsync().Result)
            { //Get all tickets
                tickets.Add(new Ticket(document));
            }
            return tickets;
        }
        public List<Ticket> GetTicketsFromSearchQuery(string query)
        {
            List<Ticket> tickets = new List<Ticket>();

            //Code for making the index
            //collection.Indexes.DropOne("title_text_description_text");
            //var indexKeys = Builders<BsonDocument>.IndexKeys.Text("Title").Text("Description");
            //collection.Indexes.CreateOneAsync(new CreateIndexModel<BsonDocument>(indexKeys));
            if(query.Trim() == "")
            {
                return GetAllTickets();
            }
            //Split the query at " or "
            string[] orSplits = query.Split(" or ");
            List<FilterDefinition<BsonDocument>> andFilters = new List<FilterDefinition<BsonDocument>>();
            foreach (string orSplit in orSplits)
            {
                //Got all queries prepared
                //Now to split it at " and "
                string[] andSplits = orSplit.Split(" and ");
                List<FilterDefinition<BsonDocument>> currentFilters = new List<FilterDefinition<BsonDocument>>();
                foreach (string andSplit in andSplits)
                {
                    //Make filter for each split
                    currentFilters.Add(Builders<BsonDocument>.Filter.Text(andSplit));
                }
                andFilters.Add(Builders<BsonDocument>.Filter.And(currentFilters));
                //empty currentFilters so no duplicate filters occur.
                currentFilters.Clear();
            }
            FilterDefinition<BsonDocument> filter = Builders<BsonDocument>.Filter.Or(andFilters);

            foreach (BsonDocument document in collection.Find(filter).ToListAsync().Result) 
            { 
                //turn all results into tickets
                tickets.Add(new Ticket(document));
            }
            return tickets;
        }

        public void CreateNewTicket(Ticket ticket)
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            collection.InsertOne(ticket);
        }

        public void UpdateTicket(Ticket updatedTicket)
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            FilterDefinition<Ticket> filter = Builders<Ticket>.Filter.Eq(ticket => ticket.Id, updatedTicket.Id);
            
            collection.ReplaceOne(filter, updatedTicket);
        }
        public void DeleteTicket(Ticket ticket) 
        {
            IMongoCollection<Ticket> collection = base.mongoClient.GetDatabase("CRUDProject").GetCollection<Ticket>("Tickets");
            var filter = Builders<Ticket>.Filter.Eq(t => t.Id, ticket.Id);

            collection.DeleteOne(filter);
        }
    }
}
