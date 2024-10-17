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
using Model.Enums;
using static MongoDB.Driver.WriteConcern;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using MongoDB.Bson;

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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            PieChart chartUnresolved = new PieChart();
            PieChart chartDeadline = new PieChart();
            chartUnresolved.Size = new Size(250, 250);
            chartDeadline.Size = new Size(250, 250);
            chartUnresolved.Location = new Point(75, 75);
            chartDeadline.Location = new Point(75, 75);
            pnlUnresolvedIncidents.Controls.Add(chartUnresolved);
            pnlIncidentsPDeadline.Controls.Add(chartDeadline);
            chartDeadline.Colors = new Color[] { Color.Salmon, Color.LightGray };
            chartDeadline.Values = new float[] { 50, 40 };
            chartUnresolved.Colors = new Color[] { Color.Orange, Color.LightGray };
            chartUnresolved.Values = new float[] { 50, 40 };
        }

        private void txtFilterByEmailIncident_KeyPress(object sender, EventArgs e)
        {
            //Convert EventArgs to proper type
            KeyPressEventArgs args = (KeyPressEventArgs)e;
            //Check if the pressed key was the enter key
            if (args.KeyChar == (Char)Keys.Enter)
            {
                args.Handled = true;
                //If key was the enter key, search the tickets for those that fit
                TicketService ticketService = new TicketService();

                List<Ticket> tickets = ticketService.GetTicketsFromSearchQuery(txtFilterByEmailIncident.Text);
                PopulateTicketView(tickets);

            }
        }
        private void PopulateTicketView(List<Ticket> tickets)
        {
            ticketView.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                //Title, description, username, status, priority
                UserService userService = new UserService();
                ListViewItem li = new ListViewItem(new string[5] { ticket.Title, ticket.Description, userService.GetUserById(ticket.Reporter_id).ToString(), ticket.Status.ToString(), ((Priority)ticket.Priority).ToString() });
                li.Tag = ticket;
                ticketView.Items.Add(li);
            }
        }
        //Keeping this method here in case problems occur
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                //Update piecharts with new data
            }
            else if (tabControl.SelectedIndex == 1)
            {
                //Disable update and delete buttons until something is selected
                UpdateTicketView();
                btnDeleteIncident.Enabled = false;
                btnUpdateIncident.Enabled = false;
            }
        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            IncidentCreatorModal incidentCreatorModal = new IncidentCreatorModal(this, null);
            incidentCreatorModal.ShowDialog();
        }

        private void ticketView_SelectedIndexChanged(object sender, EventArgs e)
        {//Disables the update and delete buttons if no ticket is selected
            try{if (ticketView.SelectedItems[0] != null){
                    btnDeleteIncident.Enabled = true;
                    btnUpdateIncident.Enabled = true;
                }
            }catch{
                btnDeleteIncident.Enabled = false;
                btnUpdateIncident.Enabled = false;
            }
        }

        private void btnUpdateIncident_Click(object sender, EventArgs e)
        {
            IncidentCreatorModal incidentCreatorModal = new IncidentCreatorModal(this, (Ticket)ticketView.SelectedItems[0].Tag);
            incidentCreatorModal.ShowDialog();
        }

        private void btnDeleteIncident_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this ticket?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TicketService ticketService = new TicketService();
                ticketService.DeleteTicket((Ticket)ticketView.SelectedItems[0].Tag);
                UpdateTicketView();
            }
        }

            public void UpdateTicketView()
        {
            TicketService ticketService = new TicketService();
            List<Ticket> tickets = ticketService.GetAllTickets();
            PopulateTicketView(tickets);
        }
    }
}
