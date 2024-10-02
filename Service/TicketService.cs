using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal class TicketService
    {
        private TicketDAO ticketdb;

        public TicketService() 
        {
            ticketdb = new TicketDAO();
        }
    }
}
