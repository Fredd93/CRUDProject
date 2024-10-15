namespace Forms_UI
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTip1 = new ToolTip(components);
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            Username = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            label2 = new Label();
            LoginBtn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(873, 9);
            label5.Name = "label5";
            label5.Size = new Size(145, 46);
            label5.TabIndex = 8;
            label5.Text = "NoDesk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(742, 67);
            label6.Name = "label6";
            label6.Size = new Size(280, 28);
            label6.TabIndex = 9;
            label6.Text = "Licensed to: The Garden Group";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 183);
            label4.Name = "label4";
            label4.Size = new Size(498, 20);
            label4.TabIndex = 18;
            label4.Text = "Please provide login credentials to login to NoDesk for The Garden Group";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(490, 122);
            label3.Name = "label3";
            label3.Size = new Size(174, 41);
            label3.TabIndex = 17;
            label3.Text = "NoDesk: TGC";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(397, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(318, 27);
            textBox2.TabIndex = 14;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(397, 233);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 11;
            Username.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(564, 360);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 16;
            label1.Text = "Forgot my password?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(397, 360);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 15;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 256);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(397, 298);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 12;
            label2.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(430, 418);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(258, 45);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 585);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(Username);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(LoginBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip toolTip1;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label Username;
        private Label label1;
        private CheckBox checkBox1;
        private TextBox textBox1;
        private Label label2;
        private Button LoginBtn;
    }
}
