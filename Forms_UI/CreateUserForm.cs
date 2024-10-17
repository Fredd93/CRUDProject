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
            userService = new UserService();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxTypeofUser.Items.AddRange(Enum.GetNames(typeof(Roles)));
        }

        private void btnCancelAddUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = firstNameTextBox.Text;
                string lastname = lastNameTextBox.Text;
                string username = $"{firstname}{lastname}";
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;
                string email = emailTextBox.Text;

                if (comboBoxTypeofUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user role.");
                    return;
                }
                if (password != confirmPassword)
                {
                    MessageBox.Show("Password does not match");
                }

                Roles role = (Roles)comboBoxTypeofUser.SelectedIndex ;

                User newUser = new User(ObjectId.GenerateNewId(), firstname, lastname, username, password, email, role);

                userService.CreateUser(newUser);

                MessageBox.Show("User created successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
