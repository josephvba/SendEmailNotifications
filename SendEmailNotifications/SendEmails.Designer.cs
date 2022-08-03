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
            this.label1.Location = new System.Drawing.Point(21, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 37);
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
            this.groupBox1.Location = new System.Drawing.Point(24, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(829, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders";
            // 
            // OrderDetailslbl
            // 
            this.OrderDetailslbl.AutoSize = true;
            this.OrderDetailslbl.Location = new System.Drawing.Point(21, 128);
            this.OrderDetailslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderDetailslbl.Name = "OrderDetailslbl";
            this.OrderDetailslbl.Size = new System.Drawing.Size(0, 25);
            this.OrderDetailslbl.TabIndex = 7;
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.Location = new System.Drawing.Point(356, 37);
            this.btnSearchOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(107, 38);
            this.btnSearchOrder.TabIndex = 6;
            this.btnSearchOrder.Text = "Search";
            this.btnSearchOrder.UseVisualStyleBackColor = true;
            this.btnSearchOrder.Click += new System.EventHandler(this.btnSearchOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(578, 93);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Email New Passwords";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbOrderSearch
            // 
            this.tbOrderSearch.Location = new System.Drawing.Point(169, 37);
            this.tbOrderSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrderSearch.Name = "tbOrderSearch";
            this.tbOrderSearch.Size = new System.Drawing.Size(178, 31);
            this.tbOrderSearch.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EmpNameLbl);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.tbEmployeeId);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(24, 230);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(829, 177);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee";
            // 
            // EmpNameLbl
            // 
            this.EmpNameLbl.AutoSize = true;
            this.EmpNameLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EmpNameLbl.Location = new System.Drawing.Point(20, 117);
            this.EmpNameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmpNameLbl.Name = "EmpNameLbl";
            this.EmpNameLbl.Size = new System.Drawing.Size(0, 25);
            this.EmpNameLbl.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(356, 40);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(578, 111);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Email New Password";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbEmployeeId
            // 
            this.tbEmployeeId.Location = new System.Drawing.Point(169, 42);
            this.tbEmployeeId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmployeeId.Name = "tbEmployeeId";
            this.tbEmployeeId.Size = new System.Drawing.Size(178, 31);
            this.tbEmployeeId.TabIndex = 3;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(24, 650);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(125, 25);
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
            this.groupBox3.Location = new System.Drawing.Point(24, 428);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(810, 190);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Company Administrator";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(20, 125);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 25);
            this.lblUsername.TabIndex = 4;
            // 
            // btnUsernamePassword
            // 
            this.btnUsernamePassword.Location = new System.Drawing.Point(578, 125);
            this.btnUsernamePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsernamePassword.Name = "btnUsernamePassword";
            this.btnUsernamePassword.Size = new System.Drawing.Size(206, 37);
            this.btnUsernamePassword.TabIndex = 3;
            this.btnUsernamePassword.Text = "Email New Password";
            this.btnUsernamePassword.UseVisualStyleBackColor = true;
            this.btnUsernamePassword.Click += new System.EventHandler(this.btnUsernamePassword_Click);
            // 
            // btnSearchUsername
            // 
            this.btnSearchUsername.Location = new System.Drawing.Point(356, 63);
            this.btnSearchUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchUsername.Name = "btnSearchUsername";
            this.btnSearchUsername.Size = new System.Drawing.Size(107, 37);
            this.btnSearchUsername.TabIndex = 2;
            this.btnSearchUsername.Text = "Search";
            this.btnSearchUsername.UseVisualStyleBackColor = true;
            this.btnSearchUsername.Click += new System.EventHandler(this.btnSearchUsername_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(169, 63);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(175, 31);
            this.tbUsername.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username";
            // 
            // SendNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 695);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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

