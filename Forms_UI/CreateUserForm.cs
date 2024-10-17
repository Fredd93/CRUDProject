using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Model.Enums;
using MongoDB.Bson;
using Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Forms_UI
{
    public partial class CreateUserForm : Form
    {
        private UserService userService;

        public CreateUserForm()
        {
            InitializeComponent();
            userService = new UserService();  // Initialize the UserService
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate the combo box with the Roles enum values
            comboBoxTypeofUser.Items.AddRange(Enum.GetNames(typeof(Roles)));
        }

        private void btnCancelAddUser_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect input from text boxes
                string firstname = firstNameTextBox.Text;
                string lastname = lastNameTextBox.Text;
                string username = $"{firstname}{lastname}";  // Create username by concatenating first and last names
                string password = passwordTextBox.Text;
                string email = emailTextBox.Text;

                // Ensure a role is selected
                if (comboBoxTypeofUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user role.");
                    return;
                }

                // Parse the role from the combo box selection
                Roles role = (Roles)comboBoxTypeofUser.SelectedIndex ;

                // Create a new user object
                User newUser = new User(ObjectId.GenerateNewId(), firstname, lastname, username, password, email, role);

                // Call the service to save the user to the database
                userService.CreateUser(newUser);

                // Show success message and clear form
                MessageBox.Show("User created successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle exceptions and show error message
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
