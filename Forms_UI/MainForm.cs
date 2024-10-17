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

namespace Forms_UI
{
    public partial class MainForm : Form
    {
        UserService userService;
        TicketService ticketService;
        public MainForm()
        {
            InitializeComponent();
            userService = new UserService();
            ticketService = new TicketService();
        }

        private void tabPageDashboard_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<User> users = userService.GetAllUsers();
            PopulateUserView(users);
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
                ListViewItem li = new ListViewItem(new string[5] { ticket.Title, ticket.Description, userService.GetUserById(ticket.User_id).ToString(), ticket.Status.ToString(), ((Priority)ticket.Priority).ToString() });
                li.Tag = ticket;
                ticketView.Items.Add(li);
            }
        }
        //Keeping this method here in case problems occur



        private void PopulateUserView(List<User> users)
        {
            usersList.Items.Clear();
            foreach (User user in users)
            {
                // Populate ListView with correct values
                ListViewItem li = new ListViewItem(new string[4]
                {
                    user.First_Name,
                    user.Last_Name,
                    user.Email,
                    user.Role.ToString()  // Ensure the role is shown as a string
                });
                li.Tag = user;
                usersList.Items.Add(li);
            }
        }


        private ListViewItem CreateUserListViewItem(User user)
        {
            return new ListViewItem(new string[4] {
                user.First_Name,
                user.Last_Name,
                user.Username,
                user.Role.ToString()
            })
            { Tag = user };
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateIncident_Click(object sender, EventArgs e)
        {
            IncidentCreatorModal incidentCreatorModal = new IncidentCreatorModal(this);
            incidentCreatorModal.ShowDialog();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0)
            {
                User selectedUser = (User)usersList.SelectedItems[0].Tag;

                userService.DeleteUser(selectedUser.Id);

                MessageBox.Show("User updated successfully!");
            }
            else
            {
                MessageBox.Show("Please select a user to update.");
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (usersList.SelectedItems.Count > 0) 
            {
                UpdateUserForm updateUserForm = new UpdateUserForm();
                updateUserForm.Show();
            }
            else
            {
                MessageBox.Show("Select a user to update");
            }
        }
    }
}
