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
            ticketView.Items.Clear();
            foreach (Ticket ticket in tickets)
            {
                //Title, description, status, user id, duration
                ListViewItem li = new ListViewItem(new string[4] { ticket.Title, ticket.Description, ticket.Status.ToString(), ticket.User_id.ToString() });
                li.Tag = ticket;
                ticketView.Items.Add(li);
            }
        }

        private void txtFilterByEmailIncident_KeyPress(object sender, EventArgs e)
        {
            //Convert EventArgs to proper type
            KeyPressEventArgs args = (KeyPressEventArgs)e;
            //Check if the pressed key was the enter key
            if(args.KeyChar == (Char)Keys.Enter)
            {
                FindSearchTerms(txtFilterByEmailIncident.Text);
            }
        }
        private void FindSearchTerms(string text)
        {

        }
    }
}
