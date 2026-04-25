using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace Cafe_ccst
{
    public partial class l : Form
    {
        public l()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string firstname = txtFirstname.Text.Trim();
            string lastname = txtLastname.Text.Trim();
            string middlename = txtMiddlename.Text.Trim();
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmpassword = txtConfirmpassword.Text.Trim();

            if (firstname == "" || lastname == "" /* ... your other checks ... */)
            {
                MessageBox.Show("Please fill in all required fields.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (password != confirmpassword)
            {
                MessageBox.Show("Passwords do not match.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- NEW CODE: Check if the email is formatted correctly ---
            try
            {
                // This will try to format the text as an email. If it's fake (missing @ or .com), it will trigger the catch block.
                var validEmail = new System.Net.Mail.MailAddress(email);
            }
            catch (FormatException)
            {
                // Stops the registration and warns the user
                MessageBox.Show("Please enter a valid email address (e.g., name@example.com).", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DBConnect db = new DBConnect();

            try
            {
                db.Open();
                string query = "INSERT INTO accounts (firstname, lastname, middlename, email, username, password) VALUES (@firstname, @lastname, @middlename, @email, @username, @password)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query, db.Connection);

                cmd.Parameters.AddWithValue("@firstname", firstname);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@middlename", middlename);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Registration successful!", "Registration");
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (result > 0)
                {
                    MessageBox.Show("Registration successful!", "Registration");

                    // --- NEW CODE: Trigger the welcome email ---
                    SendWelcomeEmail(email, firstname);

                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.Close();
            }


        }

        private void SendWelcomeEmail(string toEmail, string firstName)
        {
            try
            {
                // 1. Set up the email content
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("brixsedillo@gmail.com", "Cafe CCST"); // YOUR email address
                mail.To.Add(toEmail);                                     // The user's email address
                mail.Subject = "Welcome to Cafe CCST!";
                mail.Body = $"Dear {firstName},\n\nThank you for creating an account with Cafe CCST. Your registration is confirmed, and we are thrilled to have you with us.\n\nWarm regards,\nThe Cafe CCST Team";

                // 2. Set up the SMTP client (This tells C# how to connect to the mail server)
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587; // The standard port for secure email

                // Put YOUR email and your 16-digit Google App Password here
                smtp.Credentials = new NetworkCredential("brixsedillo@gmail.com", "cwzw uezg mqwt gslt");
                smtp.EnableSsl = true; // Required by Gmail for security

                // 3. Send the email
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                // If the email fails (e.g., no internet), we show a warning but we don't crash the app
                MessageBox.Show("Note: Registration was successful, but we couldn't send the welcome email.\nError: " + ex.Message, "Email Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
