using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System.Security.Cryptography;
using System.IO;
using MimeKit.Utils;

using System.Data.SqlClient;

namespace SendEmailNotifications
{
    public partial class SendNotifications : Form
    {
        public SqlConnectionStringBuilder sqlConnStrBuilder;

        public SendNotifications()
        {
            InitializeComponent();
            sqlConnStrBuilder = new SqlConnectionStringBuilder();

            sqlConnStrBuilder.DataSource = "biocarecmsv3sql.database.windows.net";
            sqlConnStrBuilder.UserID = "biocare";
            sqlConnStrBuilder.Password = "63PRfdLPWuWK2B";
            sqlConnStrBuilder.InitialCatalog = "cmsv3";

            ErrorLabel.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Send Order Instructions
            var employeeName = string.Empty;
            var employeeEmail = string.Empty;
            var employeeInstructions = string.Empty;


            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnStrBuilder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("cmsapp_order_emails_app", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ORDER_NUMBER", tbOrderSearch.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employeeEmail = reader.GetString(1);
                                employeeName = reader.GetString(0);
                                employeeInstructions = reader.GetString(2);

                                if (employeeEmail != string.Empty)
                                {
                                    var email = new MimeMessage();
                                    email.From.Add(MailboxAddress.Parse("cmsnotify@biocareusa.com"));
                                    email.To.Add(MailboxAddress.Parse(employeeEmail));
                                    email.Subject = "Bio-care Tests Instructions";

                                    var builder = new BodyBuilder();
                                    var image = builder.LinkedResources.Add(@"C:\bioimages\bio_care_logo_small.png");
                                    image.ContentId = MimeUtils.GenerateMessageId();

                                    builder.HtmlBody = string.Format(
                                                    @"<center><img src=""cid:{0}""></center>
                                                     <hr />
                                                     <p>{1}:</p>
                                                     <p>This email is to provide instructions for the ordered tests. It's important to follow these instuctions to sucessfully complete every test.</p>
                                                     <p>If you already received an email with instructions ignore this message</p>
                                                     <p>{2}</p>
                                                     <p></p>
                                                     <p>
                                                     <small>Replies to this email message will not be read or responded. To contact Bio-Care, please do no reply to this message, but instead go to <a href=""http://www.biocareusa.com/contact"">www.biocareusa.com/contact</a> for contact information.</small>
                                                     </p>
                                                     <hr />", image.ContentId, employeeName, employeeInstructions);

                                    email.Body = builder.ToMessageBody();

                                    using var smtp = new SmtpClient();
                                    smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                                    smtp.Authenticate("cmsnotify@biocareusa.com", "Matrix_USA1_Ivan^10061");
                                    smtp.Send(email);
                                    smtp.Disconnect(true);

                                    ErrorLabel.Text = string.Format("Instructions Sent to {0} to {1}", employeeName, employeeEmail);
                                }

                            }

                        }
                    }

                }
            }
            catch (SqlException exp)
            {
                ErrorLabel.Text = exp.Message;
            }

            ErrorLabel.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Send Order New Password
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedBytes;

            UTF8Encoding encoder = new UTF8Encoding();

            var employeeName = string.Empty;
            var employeeEmail = string.Empty;
            var employeeInstructions = string.Empty;
            var employeeId = string.Empty;


            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnStrBuilder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("cmsapp_order_emails_app", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ORDER_NUMBER", tbOrderSearch.Text);

                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            DataSet dataset = new DataSet();
                            adapter.SelectCommand = command;
                            adapter.Fill(dataset);

                            if (dataset.Tables[0].Rows.Count > 0)
                            {
                                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                                {
                                    employeeEmail = dataset.Tables[0].Rows[i][1].ToString();
                                    employeeName = dataset.Tables[0].Rows[i][0].ToString();
                                    employeeInstructions = dataset.Tables[0].Rows[i][2].ToString();
                                    employeeId = dataset.Tables[0].Rows[i][3].ToString();

                                    if (employeeEmail != string.Empty)
                                    {
                                        var newPassword = Path.GetRandomFileName().Replace(".", "").Substring(0, 6);
                                        hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(newPassword));

                                        try
                                        {
                                            using (SqlCommand cmd = new SqlCommand("UPDATE EMPLOYEES SET PASSWORD=@PASSWORD WHERE EMPLOYEE_ID=@EMPLOYEE_ID", connection))
                                            {
                                                cmd.Parameters.AddWithValue("PASSWORD", hashedBytes);
                                                cmd.Parameters.AddWithValue("EMPLOYEE_ID", employeeId);
                                                cmd.ExecuteNonQuery();
                                            }

                                        }
                                        catch (SqlException exp)
                                        {
                                            ErrorLabel.Text = exp.Message;
                                        }

                                        var email = new MimeMessage();
                                        email.From.Add(MailboxAddress.Parse("cmsnotify@biocareusa.com"));
                                        email.To.Add(MailboxAddress.Parse(employeeEmail));
                                        email.Subject = "Bio-care password reset";

                                        var builder = new BodyBuilder();
                                        var image = builder.LinkedResources.Add(@"C:\bioimages\bio_care_logo_small.png");
                                        image.ContentId = MimeUtils.GenerateMessageId();

                                        builder.HtmlBody = string.Format(
                                                        @"<center><img src=""cid:{0}""></center>
                                                     <br>
                                                     <hr />
                                                     <p>Your Cambium Management Suite <strong>password</strong> has been changed.</p>
                                                     <p>Your new password is: {1}</p>
                                                     <p>To login go to <a href=""https://cmsv3.biocareusa.com/Login.aspx?type=emp"">Bio-Care site</a> </p>
                                                     <p>
                                                     <small>Replies to this email message will not be read or responded. To contact Bio-Care, please do no reply to this message, but instead go to <a href=""http://www.biocareusa.com/contact"">www.biocareusa.com/contact</a> for contact information.</small>
                                                     </p>
                                                     <hr />", image.ContentId, newPassword);

                                        email.Body = builder.ToMessageBody();

                                        using var smtp = new SmtpClient();
                                        smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                                        smtp.Authenticate("cmsnotify@biocareusa.com", "Matrix_USA1_Ivan^10061");
                                        smtp.Send(email);
                                        smtp.Disconnect(true);

                                        ErrorLabel.Text = string.Format("Message Sent to {0} to {1}", employeeName, employeeEmail);
                                    }
                                }

                            }
                        }

                    }
                }
            }
            catch (SqlException exp)
            {
                ErrorLabel.Text = exp.Message;
            }

            ErrorLabel.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Reset Employee Password
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedBytes;

            UTF8Encoding encoder = new UTF8Encoding();

            string newPassword;
            string employeeEmail;
            string employeeName;


            newPassword = Path.GetRandomFileName().Replace(".", "").Substring(0, 6);
            employeeEmail = string.Empty;
            employeeName = string.Empty;


            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(newPassword));

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnStrBuilder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT EMAIL, FULL_NAME FROM EMPLOYEES WHERE EMPLOYEE_ID=@EMPLOYEE_ID", connection))
                    {
                        command.Parameters.AddWithValue("EMPLOYEE_ID", tbEmployeeId.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            employeeEmail = reader.GetString(0);
                            employeeName = reader.GetString(1);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("UPDATE EMPLOYEES SET PASSWORD=@PASSWORD WHERE EMPLOYEE_ID=@EMPLOYEE_ID", connection))
                    {
                        cmd.Parameters.AddWithValue("PASSWORD", hashedBytes);
                        cmd.Parameters.AddWithValue("EMPLOYEE_ID", tbEmployeeId.Text);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException exp)
            {
                ErrorLabel.Text = exp.Message;
            }

            if (employeeEmail != string.Empty)
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("cmsnotify@biocareusa.com"));
                email.To.Add(MailboxAddress.Parse(employeeEmail));
                email.Subject = "Bio-care password reset";

                var builder = new BodyBuilder();
                var image = builder.LinkedResources.Add(@"C:\bioimages\bio_care_logo_small.png");
                image.ContentId = MimeUtils.GenerateMessageId();

                builder.HtmlBody = string.Format(
                                @"<center><img src=""cid:{0}""></center>
                             <br>
                             <hr />
                             <p>Your Cambium Management Suite <strong>password</strong> has been changed.</p>
                             <p>Your new password is: {1}</p>
                             <p>To login go to <a href=""https://cmsv3.biocareusa.com/Login.aspx?type=emp"">Bio-Care site</a> </p>
                             <p>
                             <small>Replies to this email message will not be read or responded. To contact Bio-Care, please do no reply to this message, but instead go to <a href=""http://www.biocareusa.com/contact"">www.biocareusa.com/contact</a> for contact information.</small>
                             </p>
                             <hr />", image.ContentId, newPassword);

                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("cmsnotify@biocareusa.com", "Matrix_USA1_Ivan^10061");
                smtp.Send(email);
                smtp.Disconnect(true);

                ErrorLabel.Text = string.Format("Message Sent to {0} to {1}", employeeName, employeeEmail);
            }


        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string employeeEmail;
            string employeeName;

            employeeEmail = string.Empty;
            employeeName = string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnStrBuilder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT EMAIL, FULL_NAME FROM EMPLOYEES WHERE EMPLOYEE_ID=@EMPLOYEE_ID", connection))
                    {
                        command.Parameters.AddWithValue("EMPLOYEE_ID", tbEmployeeId.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                if (!reader.IsDBNull(0))
                                    employeeEmail = reader.GetString(0);
                                if (!reader.IsDBNull(1))
                                    employeeName = reader.GetString(1);
                            }
                        }
                    }

                }
            }
            catch (SqlException exp)
            {
                ErrorLabel.Text = exp.Message;
            }

            if (employeeName != string.Empty)
                EmpNameLbl.Text = string.Format("Name: {0} - Email: {1}", employeeName, employeeEmail);
            else
                EmpNameLbl.Text = "Employee not found";

        }

        private void SendNotifications_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            int orderTestCount, orderCompletedCount, orderEmailCount;
            string CompanyName;

            orderTestCount = 0;
            orderCompletedCount = 0;
            orderEmailCount = 0;
            CompanyName = string.Empty;

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnStrBuilder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(
        @"WITH tblsum AS
(
SELECT 
1 Tests, 
CASE WHEN cod.EMPLOYEE_RECORD_UID=0 THEN 0 ELSE 1 END Completed,
e.EMAIL,
c.COMPANY_NAME 
FROM COMPANY_ORDERS co
INNER JOIN COMPANY_ORDERS_DETAILS cod ON co.ORDER_UID=cod.ORDER_UID
INNER JOIN EMPLOYEES e ON cod.EMPLOYEE_UID=e.EMPLOYEE_UID
INNER JOIN COMPANY c ON e.COMPANY_UID=c.COMPANY_UID
WHERE ORDER_NUMBER=@ORDER_NUMBER
)
SELECT 
SUM(Tests) Tests, 
SUM(Completed) Completed, 
COUNT(DISTINCT EMAIL) eMails,
MAX(COMPANY_NAME) Company
FROM tblsum", connection))
                    {
                        command.Parameters.AddWithValue("ORDER_NUMBER", tbOrderSearch.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                if (!reader.IsDBNull(0))
                                    orderTestCount = reader.GetInt32(0);
                                if (!reader.IsDBNull(1))
                                    orderCompletedCount = reader.GetInt32(1);
                                if (!reader.IsDBNull(2))
                                    orderEmailCount = reader.GetInt32(2);
                                if (!reader.IsDBNull(3))
                                    CompanyName = reader.GetString(3);
                            }
                        }
                    }

                }
            }
            catch (SqlException exp)
            {
                ErrorLabel.Text = exp.Message;
            }

            if (orderTestCount > 0)
                OrderDetailslbl.Text = string.Format("Company: {3} - Test: {0} - Completed: {1}", orderTestCount, orderCompletedCount, orderEmailCount, CompanyName);
            else
                OrderDetailslbl.Text = "Order Not Found";
        }

        private void btnSearchUsername_Click(object sender, EventArgs e)
        {
            string userEmail;
            string userFullName;

            userEmail = string.Empty;
            userFullName = string.Empty;
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnStrBuilder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT EMAIL, FULL_NAME FROM CMS_USERS WHERE USERNAME=@USERNAME", connection))
                    {
                        command.Parameters.AddWithValue("USERNAME", tbUsername.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                if (!reader.IsDBNull(0))
                                    userEmail = reader.GetString(0);
                                if (!reader.IsDBNull(1))
                                    userFullName = reader.GetString(1);
                            }
                        }
                    }

                }
            }
            catch (SqlException exp)
            {
                ErrorLabel.Text = exp.Message;
            }

            if (userFullName != string.Empty)
                lblUsername.Text = string.Format("Name: {0} - Email: {1}", userFullName, userEmail);
            else
                lblUsername.Text = "User not found";
        }

        private void btnUsernamePassword_Click(object sender, EventArgs e)
        {
            // Reset Employee Password
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();
            byte[] hashedBytes;

            UTF8Encoding encoder = new UTF8Encoding();

            string newPassword;
            string userEmail;
            string userName;
            string userFullName;


            newPassword = Path.GetRandomFileName().Replace(".", "").Substring(0, 6);
            userEmail = string.Empty;
            userFullName = string.Empty;
            userName = string.Empty;


            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(newPassword));

            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnStrBuilder.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT EMAIL, FULL_NAME FROM CMS_USERS WHERE USERNAME=@USERNAME", connection))
                    {
                        command.Parameters.AddWithValue("USERNAME", tbUsername.Text);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            userEmail = reader.GetString(0);
                            userFullName = reader.GetString(1);
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("UPDATE CMS_USERS SET PASSWORD=@PASSWORD WHERE USERNAME=@USERNAME", connection))
                    {
                        cmd.Parameters.AddWithValue("PASSWORD", hashedBytes);
                        cmd.Parameters.AddWithValue("USERNAME", tbUsername.Text);
                        cmd.ExecuteNonQuery();
                    }

                }
            }
            catch (SqlException exp)
            {
                ErrorLabel.Text = exp.Message;
            }

            if (userEmail != string.Empty)
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("cmsnotify@biocareusa.com"));
                email.To.Add(MailboxAddress.Parse(userEmail));
                email.Subject = "Bio-care password reset";

                var builder = new BodyBuilder();
                var image = builder.LinkedResources.Add(@"C:\bioimages\bio_care_logo_small.png");
                image.ContentId = MimeUtils.GenerateMessageId();

                builder.HtmlBody = string.Format(
                                @"<center><img src=""cid:{0}""></center>
                             <br>
                             <hr />
                             <p>Your Cambium Management Suite <strong>password</strong> has been changed.</p>
                             <p>Your new password is: {1}</p>
                             <p>To login go to <a href=""https://cmsv3.biocareusa.com/Login.aspx"">Bio-Care site</a> </p>
                             <p>
                             <small>Replies to this email message will not be read or responded. To contact Bio-Care, please do no reply to this message, but instead go to <a href=""http://www.biocareusa.com/contact"">www.biocareusa.com/contact</a> for contact information.</small>
                             </p>
                             <hr />", image.ContentId, newPassword);

                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                smtp.Connect("smtp.office365.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("cmsnotify@biocareusa.com", "Matrix_USA1_Ivan^10061");
                smtp.Send(email);
                smtp.Disconnect(true);

                ErrorLabel.Text = string.Format("Message Sent to {0} to {1}", userFullName, userEmail);
            }

        }
    }

}
