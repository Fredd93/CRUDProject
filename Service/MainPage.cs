using Model;
namespace Service
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            ModelClass test = new ModelClass();
            if (test.DALTest())
            {
                label1.Text = "Success";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
