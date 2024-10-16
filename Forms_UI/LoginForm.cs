using Service;
using Model;
namespace Forms_UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();

            // Initialize the user service
            _userService = new UserService();

            // Set the PasswordChar property to '*' to mask the password
            PasswordBox.PasswordChar = '*';
        }

        public void LoginBtn_Click(object sender, EventArgs e)
        {
            // Retrieve the entered username and password
            string username = UsernameBox.Text;
            string password = PasswordBox.Text;

            // Validate the user credentials using UserService
            User validUser = _userService.ValidateUser(username, password);

            if (validUser != null)
            {
                MessageBox.Show("Login successful!");

                // Proceed to the main form
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
