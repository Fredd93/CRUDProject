namespace Forms_UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label6 = new Label();
            label5 = new Label();
            tabControl = new TabControl();
            tabPageDashboard = new TabPage();
            btnShowList = new Button();
            pnlIncidentsPDeadline = new Panel();
            label7 = new Label();
            label3 = new Label();
            pnlUnresolvedIncidents = new Panel();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPageIncidentManagement = new TabPage();
            ticketView = new ListView();
            title = new ColumnHeader();
            description = new ColumnHeader();
            status = new ColumnHeader();
            user_id = new ColumnHeader();
            btnCreateIncident = new Button();
            txtFilterByEmailIncident = new TextBox();
            label9 = new Label();
            tabPageUserManagement = new TabPage();
            pnlCreateNewIncident = new Panel();
            pnlCreateUser = new Panel();
            btnAddUser = new Button();
            btnCancelAddUser = new Button();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            txtLastName = new TextBox();
            comboBoxTypeofUser = new ComboBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            comboBoxLocation = new ComboBox();
            label19 = new Label();
            txtFirstName = new TextBox();
            label18 = new Label();
            btnSubmitIncident = new Button();
            btnCancelIncidentSubmission = new Button();
            textBoxDescription = new TextBox();
            label17 = new Label();
            comboBoxDeadline = new ComboBox();
            comboBoxPriority = new ComboBox();
            comboBoxUsername = new ComboBox();
            comboBoxTypeofIncident = new ComboBox();
            txtBoxSubjectofIncident = new TextBox();
            comboBoxReportTime = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            pnlUserOverview = new Panel();
            btnAddNewUser = new Button();
            txtFilterByEmail = new TextBox();
            label8 = new Label();
            tabControl.SuspendLayout();
            tabPageDashboard.SuspendLayout();
            pnlIncidentsPDeadline.SuspendLayout();
            pnlUnresolvedIncidents.SuspendLayout();
            tabPageIncidentManagement.SuspendLayout();
            tabPageUserManagement.SuspendLayout();
            pnlCreateNewIncident.SuspendLayout();
            pnlCreateUser.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(707, 71);
            label6.Name = "label6";
            label6.Size = new Size(280, 28);
            label6.TabIndex = 12;
            label6.Text = "Licensed to: The Garden Group";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(838, 13);
            label5.Name = "label5";
            label5.Size = new Size(145, 46);
            label5.TabIndex = 11;
            label5.Text = "NoDesk";
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageDashboard);
            tabControl.Controls.Add(tabPageIncidentManagement);
            tabControl.Controls.Add(tabPageUserManagement);
            tabControl.Location = new Point(52, 105);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(935, 646);
            tabControl.TabIndex = 10;
            // 
            // tabPageDashboard
            // 
            tabPageDashboard.Controls.Add(btnShowList);
            tabPageDashboard.Controls.Add(pnlIncidentsPDeadline);
            tabPageDashboard.Controls.Add(pnlUnresolvedIncidents);
            tabPageDashboard.Controls.Add(label1);
            tabPageDashboard.Location = new Point(4, 29);
            tabPageDashboard.Name = "tabPageDashboard";
            tabPageDashboard.Padding = new Padding(3);
            tabPageDashboard.Size = new Size(927, 613);
            tabPageDashboard.TabIndex = 0;
            tabPageDashboard.Text = "Dashboard";
            tabPageDashboard.UseVisualStyleBackColor = true;
            tabPageDashboard.Click += tabPageDashboard_Click;
            // 
            // btnShowList
            // 
            btnShowList.BackColor = Color.SkyBlue;
            btnShowList.Location = new Point(770, 25);
            btnShowList.Name = "btnShowList";
            btnShowList.Size = new Size(141, 35);
            btnShowList.TabIndex = 3;
            btnShowList.Text = "Show List";
            btnShowList.UseVisualStyleBackColor = false;
            // 
            // pnlIncidentsPDeadline
            // 
            pnlIncidentsPDeadline.Controls.Add(label7);
            pnlIncidentsPDeadline.Controls.Add(label3);
            pnlIncidentsPDeadline.Location = new Point(506, 76);
            pnlIncidentsPDeadline.Name = "pnlIncidentsPDeadline";
            pnlIncidentsPDeadline.Size = new Size(405, 330);
            pnlIncidentsPDeadline.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 55);
            label7.Name = "label7";
            label7.Size = new Size(299, 20);
            label7.TabIndex = 1;
            label7.Text = "These tickets need your immidiate attention";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(109, 18);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 0;
            label3.Text = "Incidents Past Deadline";
            // 
            // pnlUnresolvedIncidents
            // 
            pnlUnresolvedIncidents.Controls.Add(label4);
            pnlUnresolvedIncidents.Controls.Add(label2);
            pnlUnresolvedIncidents.Location = new Point(21, 76);
            pnlUnresolvedIncidents.Name = "pnlUnresolvedIncidents";
            pnlUnresolvedIncidents.Size = new Size(405, 330);
            pnlUnresolvedIncidents.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 55);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 1;
            label4.Text = "All tickets currently open";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(103, 18);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 0;
            label2.Text = "Unresolved Incidents";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(297, 46);
            label1.TabIndex = 0;
            label1.Text = "Current Incidents";
            // 
            // tabPageIncidentManagement
            // 
            tabPageIncidentManagement.Controls.Add(ticketView);
            tabPageIncidentManagement.Controls.Add(btnCreateIncident);
            tabPageIncidentManagement.Controls.Add(txtFilterByEmailIncident);
            tabPageIncidentManagement.Controls.Add(label9);
            tabPageIncidentManagement.Location = new Point(4, 29);
            tabPageIncidentManagement.Name = "tabPageIncidentManagement";
            tabPageIncidentManagement.Padding = new Padding(3);
            tabPageIncidentManagement.Size = new Size(927, 613);
            tabPageIncidentManagement.TabIndex = 1;
            tabPageIncidentManagement.Text = "Incident Management";
            tabPageIncidentManagement.UseVisualStyleBackColor = true;
            // 
            // ticketView
            // 
            ticketView.Columns.AddRange(new ColumnHeader[] { title, description, status, user_id });
            ticketView.FullRowSelect = true;
            ticketView.GridLines = true;
            ticketView.Location = new Point(27, 171);
            ticketView.Name = "ticketView";
            ticketView.Size = new Size(878, 410);
            ticketView.TabIndex = 3;
            ticketView.UseCompatibleStateImageBehavior = false;
            ticketView.View = View.Details;
            // 
            // title
            // 
            title.Text = "Title";
            title.Width = 300;
            // 
            // description
            // 
            description.Text = "Description";
            description.Width = 300;
            // 
            // status
            // 
            status.Text = "Status";
            status.Width = 137;
            // 
            // user_id
            // 
            user_id.Text = "User ID";
            user_id.Width = 137;
            // 
            // btnCreateIncident
            // 
            btnCreateIncident.BackColor = Color.SkyBlue;
            btnCreateIncident.Location = new Point(757, 71);
            btnCreateIncident.Name = "btnCreateIncident";
            btnCreateIncident.Size = new Size(147, 47);
            btnCreateIncident.TabIndex = 2;
            btnCreateIncident.Text = "Create Incident";
            btnCreateIncident.UseVisualStyleBackColor = false;
            // 
            // txtFilterByEmailIncident
            // 
            txtFilterByEmailIncident.Location = new Point(26, 71);
            txtFilterByEmailIncident.Multiline = true;
            txtFilterByEmailIncident.Name = "txtFilterByEmailIncident";
            txtFilterByEmailIncident.Size = new Size(325, 47);
            txtFilterByEmailIncident.TabIndex = 1;
            txtFilterByEmailIncident.KeyPress += txtFilterByEmailIncident_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(290, 46);
            label9.TabIndex = 0;
            label9.Text = "Overview Tickets";
            // 
            // tabPageUserManagement
            // 
            tabPageUserManagement.Controls.Add(pnlCreateNewIncident);
            tabPageUserManagement.Controls.Add(pnlUserOverview);
            tabPageUserManagement.Controls.Add(btnAddNewUser);
            tabPageUserManagement.Controls.Add(txtFilterByEmail);
            tabPageUserManagement.Controls.Add(label8);
            tabPageUserManagement.Font = new Font("Segoe UI", 9F);
            tabPageUserManagement.Location = new Point(4, 29);
            tabPageUserManagement.Name = "tabPageUserManagement";
            tabPageUserManagement.Padding = new Padding(3);
            tabPageUserManagement.Size = new Size(927, 613);
            tabPageUserManagement.TabIndex = 2;
            tabPageUserManagement.Text = "User Management";
            tabPageUserManagement.UseVisualStyleBackColor = true;
            // 
            // pnlCreateNewIncident
            // 
            pnlCreateNewIncident.Controls.Add(pnlCreateUser);
            pnlCreateNewIncident.Controls.Add(btnSubmitIncident);
            pnlCreateNewIncident.Controls.Add(btnCancelIncidentSubmission);
            pnlCreateNewIncident.Controls.Add(textBoxDescription);
            pnlCreateNewIncident.Controls.Add(label17);
            pnlCreateNewIncident.Controls.Add(comboBoxDeadline);
            pnlCreateNewIncident.Controls.Add(comboBoxPriority);
            pnlCreateNewIncident.Controls.Add(comboBoxUsername);
            pnlCreateNewIncident.Controls.Add(comboBoxTypeofIncident);
            pnlCreateNewIncident.Controls.Add(txtBoxSubjectofIncident);
            pnlCreateNewIncident.Controls.Add(comboBoxReportTime);
            pnlCreateNewIncident.Controls.Add(label16);
            pnlCreateNewIncident.Controls.Add(label15);
            pnlCreateNewIncident.Controls.Add(label14);
            pnlCreateNewIncident.Controls.Add(label13);
            pnlCreateNewIncident.Controls.Add(label12);
            pnlCreateNewIncident.Controls.Add(label11);
            pnlCreateNewIncident.Controls.Add(label10);
            pnlCreateNewIncident.Location = new Point(3, 1);
            pnlCreateNewIncident.Name = "pnlCreateNewIncident";
            pnlCreateNewIncident.Size = new Size(924, 616);
            pnlCreateNewIncident.TabIndex = 4;
            // 
            // pnlCreateUser
            // 
            pnlCreateUser.Controls.Add(btnAddUser);
            pnlCreateUser.Controls.Add(btnCancelAddUser);
            pnlCreateUser.Controls.Add(textBoxPhone);
            pnlCreateUser.Controls.Add(textBoxEmail);
            pnlCreateUser.Controls.Add(txtLastName);
            pnlCreateUser.Controls.Add(comboBoxTypeofUser);
            pnlCreateUser.Controls.Add(label24);
            pnlCreateUser.Controls.Add(label23);
            pnlCreateUser.Controls.Add(label22);
            pnlCreateUser.Controls.Add(label21);
            pnlCreateUser.Controls.Add(label20);
            pnlCreateUser.Controls.Add(comboBoxLocation);
            pnlCreateUser.Controls.Add(label19);
            pnlCreateUser.Controls.Add(txtFirstName);
            pnlCreateUser.Controls.Add(label18);
            pnlCreateUser.Location = new Point(-3, 0);
            pnlCreateUser.Name = "pnlCreateUser";
            pnlCreateUser.Size = new Size(924, 616);
            pnlCreateUser.TabIndex = 17;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.SkyBlue;
            btnAddUser.Location = new Point(406, 407);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(125, 41);
            btnAddUser.TabIndex = 14;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnCancelAddUser
            // 
            btnCancelAddUser.Location = new Point(174, 407);
            btnCancelAddUser.Name = "btnCancelAddUser";
            btnCancelAddUser.Size = new Size(125, 41);
            btnCancelAddUser.TabIndex = 13;
            btnCancelAddUser.Text = "Cancel";
            btnCancelAddUser.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(174, 285);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(357, 27);
            textBoxPhone.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(174, 234);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(357, 27);
            textBoxEmail.TabIndex = 11;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(174, 140);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(357, 27);
            txtLastName.TabIndex = 10;
            // 
            // comboBoxTypeofUser
            // 
            comboBoxTypeofUser.FormattingEnabled = true;
            comboBoxTypeofUser.Location = new Point(174, 186);
            comboBoxTypeofUser.Name = "comboBoxTypeofUser";
            comboBoxTypeofUser.Size = new Size(357, 28);
            comboBoxTypeofUser.TabIndex = 9;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F);
            label24.Location = new Point(17, 335);
            label24.Name = "label24";
            label24.Size = new Size(139, 23);
            label24.TabIndex = 8;
            label24.Text = "Location/Branch:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F);
            label23.Location = new Point(17, 285);
            label23.Name = "label23";
            label23.Size = new Size(128, 23);
            label23.TabIndex = 7;
            label23.Text = "Phone number:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F);
            label22.Location = new Point(17, 234);
            label22.Name = "label22";
            label22.Size = new Size(125, 23);
            label22.TabIndex = 6;
            label22.Text = "E-mail address:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(17, 186);
            label21.Name = "label21";
            label21.Size = new Size(106, 23);
            label21.TabIndex = 5;
            label21.Text = "Type of user:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(17, 140);
            label20.Name = "label20";
            label20.Size = new Size(92, 23);
            label20.TabIndex = 4;
            label20.Text = "Last name:";
            // 
            // comboBoxLocation
            // 
            comboBoxLocation.FormattingEnabled = true;
            comboBoxLocation.Location = new Point(174, 335);
            comboBoxLocation.Name = "comboBoxLocation";
            comboBoxLocation.Size = new Size(357, 28);
            comboBoxLocation.TabIndex = 3;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F);
            label19.Location = new Point(17, 90);
            label19.Name = "label19";
            label19.Size = new Size(93, 23);
            label19.TabIndex = 2;
            label19.Text = "First name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(174, 90);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(357, 27);
            txtFirstName.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(0, -1);
            label18.Name = "label18";
            label18.Size = new Size(284, 46);
            label18.TabIndex = 0;
            label18.Text = "Create New User";
            // 
            // btnSubmitIncident
            // 
            btnSubmitIncident.BackColor = Color.SkyBlue;
            btnSubmitIncident.Location = new Point(389, 548);
            btnSubmitIncident.Name = "btnSubmitIncident";
            btnSubmitIncident.Size = new Size(125, 41);
            btnSubmitIncident.TabIndex = 16;
            btnSubmitIncident.Text = "Submit Incident";
            btnSubmitIncident.UseVisualStyleBackColor = false;
            // 
            // btnCancelIncidentSubmission
            // 
            btnCancelIncidentSubmission.Location = new Point(197, 548);
            btnCancelIncidentSubmission.Name = "btnCancelIncidentSubmission";
            btnCancelIncidentSubmission.Size = new Size(125, 41);
            btnCancelIncidentSubmission.TabIndex = 15;
            btnCancelIncidentSubmission.Text = "Cancel";
            btnCancelIncidentSubmission.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(195, 376);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(319, 157);
            textBoxDescription.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 379);
            label17.Name = "label17";
            label17.Size = new Size(88, 20);
            label17.TabIndex = 13;
            label17.Text = "Description:";
            // 
            // comboBoxDeadline
            // 
            comboBoxDeadline.FormattingEnabled = true;
            comboBoxDeadline.Location = new Point(195, 321);
            comboBoxDeadline.Name = "comboBoxDeadline";
            comboBoxDeadline.Size = new Size(319, 28);
            comboBoxDeadline.TabIndex = 12;
            // 
            // comboBoxPriority
            // 
            comboBoxPriority.FormattingEnabled = true;
            comboBoxPriority.Location = new Point(195, 271);
            comboBoxPriority.Name = "comboBoxPriority";
            comboBoxPriority.Size = new Size(319, 28);
            comboBoxPriority.TabIndex = 11;
            // 
            // comboBoxUsername
            // 
            comboBoxUsername.FormattingEnabled = true;
            comboBoxUsername.Location = new Point(195, 225);
            comboBoxUsername.Name = "comboBoxUsername";
            comboBoxUsername.Size = new Size(319, 28);
            comboBoxUsername.TabIndex = 10;
            // 
            // comboBoxTypeofIncident
            // 
            comboBoxTypeofIncident.FormattingEnabled = true;
            comboBoxTypeofIncident.Location = new Point(195, 181);
            comboBoxTypeofIncident.Name = "comboBoxTypeofIncident";
            comboBoxTypeofIncident.Size = new Size(319, 28);
            comboBoxTypeofIncident.TabIndex = 9;
            // 
            // txtBoxSubjectofIncident
            // 
            txtBoxSubjectofIncident.Location = new Point(195, 136);
            txtBoxSubjectofIncident.Name = "txtBoxSubjectofIncident";
            txtBoxSubjectofIncident.Size = new Size(319, 27);
            txtBoxSubjectofIncident.TabIndex = 8;
            // 
            // comboBoxReportTime
            // 
            comboBoxReportTime.FormattingEnabled = true;
            comboBoxReportTime.Location = new Point(195, 95);
            comboBoxReportTime.Name = "comboBoxReportTime";
            comboBoxReportTime.Size = new Size(319, 28);
            comboBoxReportTime.TabIndex = 7;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(21, 321);
            label16.Name = "label16";
            label16.Size = new Size(161, 23);
            label16.TabIndex = 6;
            label16.Text = "Deadline/Follow up:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(21, 271);
            label15.Name = "label15";
            label15.Size = new Size(68, 23);
            label15.TabIndex = 5;
            label15.Text = "Priority:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(21, 225);
            label14.Name = "label14";
            label14.Size = new Size(144, 23);
            label14.TabIndex = 4;
            label14.Text = "Reported by user:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(21, 181);
            label13.Name = "label13";
            label13.Size = new Size(135, 23);
            label13.TabIndex = 3;
            label13.Text = "Type of incident:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(21, 136);
            label12.Name = "label12";
            label12.Size = new Size(156, 23);
            label12.TabIndex = 2;
            label12.Text = "Subject of incident:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(21, 95);
            label11.Name = "label11";
            label11.Size = new Size(165, 23);
            label11.TabIndex = 1;
            label11.Text = "Date/Time reported:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, -1);
            label10.Name = "label10";
            label10.Size = new Size(343, 46);
            label10.TabIndex = 0;
            label10.Text = "Create New Incident";
            // 
            // pnlUserOverview
            // 
            pnlUserOverview.Location = new Point(24, 150);
            pnlUserOverview.Name = "pnlUserOverview";
            pnlUserOverview.Size = new Size(876, 433);
            pnlUserOverview.TabIndex = 3;
            // 
            // btnAddNewUser
            // 
            btnAddNewUser.BackColor = Color.SkyBlue;
            btnAddNewUser.Location = new Point(753, 80);
            btnAddNewUser.Name = "btnAddNewUser";
            btnAddNewUser.Size = new Size(147, 47);
            btnAddNewUser.TabIndex = 2;
            btnAddNewUser.Text = "+Add New User";
            btnAddNewUser.UseVisualStyleBackColor = false;
            // 
            // txtFilterByEmail
            // 
            txtFilterByEmail.Location = new Point(24, 80);
            txtFilterByEmail.Multiline = true;
            txtFilterByEmail.Name = "txtFilterByEmail";
            txtFilterByEmail.Size = new Size(325, 47);
            txtFilterByEmail.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 26);
            label8.Name = "label8";
            label8.Size = new Size(313, 46);
            label8.TabIndex = 0;
            label8.Text = "User Management";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 783);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tabControl);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabPageDashboard.ResumeLayout(false);
            tabPageDashboard.PerformLayout();
            pnlIncidentsPDeadline.ResumeLayout(false);
            pnlIncidentsPDeadline.PerformLayout();
            pnlUnresolvedIncidents.ResumeLayout(false);
            pnlUnresolvedIncidents.PerformLayout();
            tabPageIncidentManagement.ResumeLayout(false);
            tabPageIncidentManagement.PerformLayout();
            tabPageUserManagement.ResumeLayout(false);
            tabPageUserManagement.PerformLayout();
            pnlCreateNewIncident.ResumeLayout(false);
            pnlCreateNewIncident.PerformLayout();
            pnlCreateUser.ResumeLayout(false);
            pnlCreateUser.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private TabControl tabControl;
        private TabPage tabPageDashboard;
        private TabPage tabPageIncidentManagement;
        private TabPage tabPageUserManagement;
        private Label label1;
        private Panel pnlIncidentsPDeadline;
        private Panel pnlUnresolvedIncidents;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btnShowList;
        private Button btnAddNewUser;
        private TextBox txtFilterByEmail;
        private Label label8;
        private Panel pnlUserOverview;
        private Label label9;
        private Button btnCreateIncident;
        private TextBox txtFilterByEmailIncident;
        private Panel pnlCreateNewIncident;
        private ComboBox comboBoxDeadline;
        private ComboBox comboBoxPriority;
        private ComboBox comboBoxUsername;
        private ComboBox comboBoxTypeofIncident;
        private TextBox txtBoxSubjectofIncident;
        private ComboBox comboBoxReportTime;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Button btnSubmitIncident;
        private Button btnCancelIncidentSubmission;
        private TextBox textBoxDescription;
        private Label label17;
        private Panel pnlCreateUser;
        private Label label18;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox txtLastName;
        private ComboBox comboBoxTypeofUser;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private ComboBox comboBoxLocation;
        private Label label19;
        private TextBox txtFirstName;
        private Button btnAddUser;
        private Button btnCancelAddUser;
        private ListView ticketView;
        private ColumnHeader title;
        private ColumnHeader description;
        private ColumnHeader status;
        private ColumnHeader user_id;
    }
}