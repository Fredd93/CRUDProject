namespace Forms_UI
{
    partial class CreateNewUser
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
            txtConfirmPassword = new TextBox();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblPassword = new Label();
            pnlCreateUser.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCreateUser
            // 
            pnlCreateUser.Controls.Add(lblPassword);
            pnlCreateUser.Controls.Add(lblConfirmPassword);
            pnlCreateUser.Controls.Add(txtPassword);
            pnlCreateUser.Controls.Add(txtConfirmPassword);
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
            pnlCreateUser.Location = new Point(12, 12);
            pnlCreateUser.Name = "pnlCreateUser";
            pnlCreateUser.Size = new Size(574, 616);
            pnlCreateUser.TabIndex = 18;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.SkyBlue;
            btnAddUser.Location = new Point(406, 491);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(125, 41);
            btnAddUser.TabIndex = 14;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // btnCancelAddUser
            // 
            btnCancelAddUser.Location = new Point(174, 491);
            btnCancelAddUser.Name = "btnCancelAddUser";
            btnCancelAddUser.Size = new Size(125, 41);
            btnCancelAddUser.TabIndex = 13;
            btnCancelAddUser.Text = "Cancel";
            btnCancelAddUser.UseVisualStyleBackColor = true;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(174, 369);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(357, 27);
            textBoxPhone.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(174, 318);
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
            comboBoxTypeofUser.Location = new Point(174, 270);
            comboBoxTypeofUser.Name = "comboBoxTypeofUser";
            comboBoxTypeofUser.Size = new Size(357, 28);
            comboBoxTypeofUser.TabIndex = 9;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F);
            label24.Location = new Point(17, 419);
            label24.Name = "label24";
            label24.Size = new Size(139, 23);
            label24.TabIndex = 8;
            label24.Text = "Location/Branch:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F);
            label23.Location = new Point(17, 369);
            label23.Name = "label23";
            label23.Size = new Size(128, 23);
            label23.TabIndex = 7;
            label23.Text = "Phone number:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F);
            label22.Location = new Point(17, 318);
            label22.Name = "label22";
            label22.Size = new Size(125, 23);
            label22.TabIndex = 6;
            label22.Text = "E-mail address:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(17, 270);
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
            comboBoxLocation.Location = new Point(174, 419);
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
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(174, 227);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(357, 27);
            txtConfirmPassword.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 185);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(357, 27);
            txtPassword.TabIndex = 16;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F);
            lblConfirmPassword.Location = new Point(18, 227);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(151, 23);
            lblConfirmPassword.TabIndex = 17;
            lblConfirmPassword.Text = "Confirm password:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F);
            lblPassword.Location = new Point(17, 185);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 23);
            lblPassword.TabIndex = 18;
            lblPassword.Text = "Password:";
            // 
            // CreateNewUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 681);
            Controls.Add(pnlCreateUser);
            Name = "CreateNewUser";
            Text = "CreateNewUser";
            pnlCreateUser.ResumeLayout(false);
            pnlCreateUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCreateUser;
        private Button btnAddUser;
        private Button btnCancelAddUser;
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
        private Label label18;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
    }
}