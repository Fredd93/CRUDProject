using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Model;
using static MongoDB.Driver.WriteConcern;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Forms_UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPageDashboard_Click(object sender, EventArgs e)
        {
            PieChart chart = new PieChart();
            pnlUnresolvedIncidents.Controls.Add(chart);
            pnlIncidentsPDeadline.Controls.Add(chart);
            chart.Colors = new Color[] { Color.Salmon, Color.Orange, Color.Lime };
            chart.Values = new float[] { 10, 20, 40 };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.GetAllTickets();
            PopulateTicketView(tickets);
        }

        private void txtFilterByEmailIncident_KeyPress(object sender, EventArgs e)
        {
            //Convert EventArgs to proper type
            KeyPressEventArgs args = (KeyPressEventArgs)e;
            //Check if the pressed key was the enter key
            if(args.KeyChar == (Char)Keys.Enter)
            {
                args.Handled = true;
                //If key was the enter key, search the tickets for those that fit
                TicketService ticketService = new TicketService();
                //Populate listview with all tickets before filtering them
                PopulateTicketView(ticketService.GetAllTickets());
                List<Ticket> tickets = SearchForTickets(txtFilterByEmailIncident.Text);

                PopulateTicketView(tickets);
            }
        }
        private void PopulateTicketView(List<Ticket> tickets)
        {
            ticketView.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                //Title, description, status, user id, duration
                ListViewItem li = new ListViewItem(new string[4] { ticket.Title, ticket.Description, ticket.Status.ToString(), ticket.User_id.ToString() });
                li.Tag = ticket;
                ticketView.Items.Add(li);
            }
        }
        private List<Ticket> SearchForTickets(string text)
        {
            string query = text.ToLower(); //Make the query lowercase for simplicity,
                                           //also avoids having to look for both 'and' and 'AND'. Same with 'or' and 'OR'
            query = query.Replace(", ", " or "); //turn every , into an 'or'. Other way around would work too
            query = query.Replace(" & ", " and "); //turn every & into an 'and'. Other way around would work too
            string[] splits = query.Split(" or "); //split the query into pieces to search for the different keywords
            List<Ticket> results = new List<Ticket>();
            foreach (string s in splits)
            {
                string[] searchKeywords = s.Split(" and "); //split any keywords with an 'and' in them
                foreach (ListViewItem li in ticketView.Items)
                {
                    Ticket ticket = (Ticket)li.Tag;
                    bool hasKeywords = true;
                    foreach (string keyword in searchKeywords)
                    {
                        string trimmedKeyword = keyword.Trim(); //remove trailing whitespace that could mess up the search
                        if (!ticket.Title.ToLower().Contains(trimmedKeyword) && !ticket.Description.ToLower().Contains(trimmedKeyword)) { hasKeywords = false; break; } //set to lowercase to avoid capitalization mistakes
                    }
                    if (hasKeywords && !results.Contains(ticket)) //if there isn't already a copy in the list,
                                                                  //because the query has 2 keywords that apply
                    {
                        results.Add(ticket);
                    }
                }
            }
            return results;
        }
    }
}
