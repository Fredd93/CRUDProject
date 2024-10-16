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

namespace Forms_UI
{
    public partial class IncidentCreatorModal : Form
    {
        MainForm mainForm;
        public IncidentCreatorModal(MainForm parentForm)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            mainForm = parentForm;
            UserService userService = new UserService();
            PopulateReporterComboBox(userService.GetAllUsers());
            PopulateHandlerComboBox(userService.GetAllServiceUsers());

        }

        private void PopulateReporterComboBox(List<User> users)
        {
            foreach (User user in users)
            {
                
                comboBoxUsername.Items.Add(user);
            }
        }
        private void PopulateHandlerComboBox(List<User> users)
        {
            foreach (User user in users)
            {

                comboBoxHandler.Items.Add(user);
            }
        }

        private void btnCancelIncidentSubmission_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmitIncident_Click(object sender, EventArgs e)
        {
            Priority priority;
            try
            {
                priority = (Priority)Enum.Parse(typeof(Priority), comboBoxPriority.Text);
            }catch
            {
                priority = Priority.Low;
            }
            
            TicketService ticketService = new TicketService();

            ObjectId reporterid = ((User)(comboBoxUsername.SelectedItem)).Id;
            ObjectId handlerid = ((User)(comboBoxHandler.SelectedItem)).Id;
            Ticket ticket = new Ticket(txtBoxSubjectofIncident.Text, textBoxDescription.Text, reporterid, handlerid, Status.open, dateTimeReportTime.Value, dateTimeDeadline.Value, priority);

            ticketService.CreateNewTicket(ticket);
            MessageBox.Show("Ticket succesfully added");
            this.Close();
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                // Disable the close button by removing the system menu close option
                const int CS_NOCLOSE = 0x200;
                myCp.ClassStyle |= CS_NOCLOSE;
                return myCp;
            }
        }
    }
}
