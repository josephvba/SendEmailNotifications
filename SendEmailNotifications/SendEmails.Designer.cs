namespace SendEmailNotifications
{
    partial class SendNotifications
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderDetailslbl = new System.Windows.Forms.Label();
            this.btnSearchOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbOrderSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EmpNameLbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbEmployeeId = new System.Windows.Forms.TextBox();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnUsernamePassword = new System.Windows.Forms.Button();
            this.btnSearchUsername = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Email Instructions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OrderDetailslbl);
            this.groupBox1.Controls.Add(this.btnSearchOrder);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbOrderSearch);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(580, 106);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // OrderDetailslbl
            // 
            this.OrderDetailslbl.AutoSize = true;
            this.OrderDetailslbl.Location = new System.Drawing.Point(15, 77);
            this.OrderDetailslbl.Name = "OrderDetailslbl";
            this.OrderDetailslbl.Size = new System.Drawing.Size(0, 15);
            this.OrderDetailslbl.TabIndex = 7;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(249, 22);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(75, 23);
            this.btnSearchOrder.TabIndex = 6;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 56);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "Email New Passwords";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbOrderSearch
            // 
            this.tbOrderSearch.Location = new System.Drawing.Point(118, 22);
            this.tbOrderSearch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbOrderSearch.Name = "tbOrderSearch";
            this.tbOrderSearch.Size = new System.Drawing.Size(126, 23);
            this.tbOrderSearch.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmpNameLbl);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.tbEmployeeId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(17, 138);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(580, 106);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee";
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpNameLbl.Location = new System.Drawing.Point(14, 70);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(0, 15);
            this.EmpNameLbl.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(249, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(412, 66);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 22);
            this.button3.TabIndex = 4;
            this.button3.Text = "Email New Password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Location = new System.Drawing.Point(118, 25);
            this.tbEmployeeId.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.Size = new System.Drawing.Size(126, 23);
            this.tbEmployeeId.TabIndex = 3;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(17, 390);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(81, 15);
            this.ErrorLabel.TabIndex = 8;
            this.ErrorLabel.Text = "Error Message";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblUsername);
            this.groupBox3.Controls.Add(this.btnUsernamePassword);
            this.groupBox3.Controls.Add(this.btnSearchUsername);
            this.groupBox3.Controls.Add(this.tbUsername);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(17, 257);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(567, 114);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company Administrator";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 75);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 15);
            this.lblUsername.TabIndex = 4;
            // 
            // btnUsernamePassword
            // 
            this.btnUsernamePassword.Location = new System.Drawing.Point(412, 75);
            this.btnUsernamePassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnUsernamePassword.Name = "btnUsernamePassword";
            this.btnUsernamePassword.Size = new System.Drawing.Size(144, 22);
            this.btnUsernamePassword.TabIndex = 3;
            this.btnUsernamePassword.Text = "Email New Password";
            this.btnUsernamePassword.UseVisualStyleBackColor = true;
            this.btnUsernamePassword.Click += new System.EventHandler(this.btnUsernamePassword_Click);
            // 
            // btnSearchUsername
            // 
            this.btnSearchUsername.Location = new System.Drawing.Point(249, 38);
            this.btnSearchUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSearchUsername.Name = "btnSearchUsername";
            this.btnSearchUsername.Size = new System.Drawing.Size(75, 22);
            this.btnSearchUsername.TabIndex = 2;
            this.btnSearchUsername.Text = "Search";
            this.btnSearchUsername.UseVisualStyleBackColor = true;
            this.btnSearchUsername.Click += new System.EventHandler(this.btnSearchUsername_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(118, 38);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(124, 23);
            this.tbUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // SendNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 417);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "SendNotifications";
            this.Text = "Send Notifications";
            this.Load += new System.EventHandler(this.SendNotifications_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbOrderSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbEmployeeId;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label EmpNameLbl;
        private System.Windows.Forms.Button btnSearchOrder;
        private System.Windows.Forms.Label OrderDetailslbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnUsernamePassword;
        private System.Windows.Forms.Button btnSearchUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
    }
}

