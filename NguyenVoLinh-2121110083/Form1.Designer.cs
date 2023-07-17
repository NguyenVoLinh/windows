namespace NguyenVoLinh_2121110083
{
    partial class Form1
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lblg = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.lbsdt = new System.Windows.Forms.Label();
            this.lbns = new System.Windows.Forms.Label();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.lbgt = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(105, 90);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 22);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(105, 144);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(197, 22);
            this.txtPassword.TabIndex = 0;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(24, 90);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(73, 17);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(27, 148);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(69, 17);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            this.lbPassword.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(105, 458);
            this.btLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(88, 28);
            this.btLogin.TabIndex = 2;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(216, 458);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(88, 28);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lblg
            // 
            this.lblg.AutoSize = true;
            this.lblg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblg.Location = new System.Drawing.Point(159, 49);
            this.lblg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblg.Name = "lblg";
            this.lblg.Size = new System.Drawing.Size(65, 25);
            this.lblg.TabIndex = 3;
            this.lblg.Text = "Login";
            this.lblg.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.Color.Red;
            this.lbRegister.Location = new System.Drawing.Point(161, 426);
            this.lbRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(145, 15);
            this.lbRegister.TabIndex = 4;
            this.lbRegister.Text = "Do not have an account? ";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(105, 201);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(197, 22);
            this.txtsdt.TabIndex = 0;
            // 
            // lbsdt
            // 
            this.lbsdt.AutoSize = true;
            this.lbsdt.Location = new System.Drawing.Point(4, 201);
            this.lbsdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbsdt.Name = "lbsdt";
            this.lbsdt.Size = new System.Drawing.Size(91, 17);
            this.lbsdt.TabIndex = 1;
            this.lbsdt.Text = "Số điện thoại";
            this.lbsdt.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // lbns
            // 
            this.lbns.AutoSize = true;
            this.lbns.Location = new System.Drawing.Point(16, 265);
            this.lbns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbns.Name = "lbns";
            this.lbns.Size = new System.Drawing.Size(71, 17);
            this.lbns.TabIndex = 1;
            this.lbns.Text = "Ngày sinh";
            this.lbns.Click += new System.EventHandler(this.lbPassword_Click);
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(129, 316);
            this.radioMale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(59, 21);
            this.radioMale.TabIndex = 5;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(227, 316);
            this.radioFemale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(75, 21);
            this.radioFemale.TabIndex = 5;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // lbgt
            // 
            this.lbgt.AutoSize = true;
            this.lbgt.Location = new System.Drawing.Point(43, 316);
            this.lbgt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbgt.Name = "lbgt";
            this.lbgt.Size = new System.Drawing.Size(60, 17);
            this.lbgt.TabIndex = 6;
            this.lbgt.Text = "Gioi tính";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(96, 265);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 567);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbgt);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMale);
            this.Controls.Add(this.lbRegister);
            this.Controls.Add(this.lblg);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbns);
            this.Controls.Add(this.lbsdt);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "l";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblg;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label lbsdt;
        private System.Windows.Forms.Label lbns;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.Label lbgt;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

