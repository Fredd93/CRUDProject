using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TicketService
    {
        private TicketDAO ticketdb;

        public TicketService() 
        {
            ticketdb = new TicketDAO();
        }
        public List<Ticket> GetAllTickets()
        {
            return ticketdb.GetAllTickets();
        }
        public List<Ticket> GetTicketsFromSearchQuery(string query)
        {
            return ticketdb.GetTicketsFromSearchQuery(query);
        }
        public void CreateNewTicket(Ticket ticket)
        {
            ticketdb.CreateNewTicket(ticket);
        }
        public void UpdateTicket(Ticket ticket)
        {
            ticketdb.UpdateTicket(ticket);
        }
        public void DeleteTicket(Ticket ticket)
        {
            ticketdb.DeleteTicket(ticket);
        }
    }
}
