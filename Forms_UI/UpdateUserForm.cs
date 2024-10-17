using Model.Enums;
using MongoDB.Bson;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_UI
{
    public partial class UpdateUserForm : Form
    {
        private UserService userService;
        public UpdateUserForm()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            comboBoxTypeofUser.Items.AddRange(Enum.GetNames(typeof(Roles)));
            MainForm mainForm = new MainForm();
            User user = (User)mainForm.usersList.SelectedItems[0].Tag;
            firstNameTextBox.Text = user.First_Name;
            lastNameTextBox.Text = user.Last_Name;
            comboBoxTypeofUser.Text = user.Role.ToString();
            idTextBox.Text = user.Id.ToString();
            emailTextBox.Text = user.Email;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string firstname = firstNameTextBox.Text;
                string lastname = lastNameTextBox.Text;
                string username = $"{firstname}{lastname}";
                string email = emailTextBox.Text;

                if (comboBoxTypeofUser.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a user role.");
                    return;
                }

                Roles role = (Roles)comboBoxTypeofUser.SelectedIndex;

                User updatedUser = new User()
                {
                    First_Name = firstNameTextBox.Text,
                    Last_Name = lastNameTextBox.Text,
                    Username = username,
                    Email = email,
                };

                userService.UpdateUser(updatedUser);

                MessageBox.Show("User updated successfully!");
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

        }
    }
}
