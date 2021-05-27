using System;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Scheduling_Interviews.Login;

namespace Scheduling_Interviews
{
    public partial class LoginForm : Form

    {
        public static bool isLoggedIn = false;
        private CallServer server;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            isLoggedIn = true;
           /* var check = server.CallHTTP(txtEmail.Text, txtPassword.Text);
            if (txtEmail.Text == ""  || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the required details");
                return;
            }
            else
            {
                if (check == "Does not exist")
                {
                    MessageBox.Show("Sorry, Email Does Not Exist!");
                }
                else if (check == "incorrect")
                {
                    MessageBox.Show("Password Is Incorrect!");
                }
                else
                {
                    MessageBox.Show(check);
                    this.Close();
                    isLoggedIn = true;
                }

            }*/
        }


        public LoginForm()
        {
            InitializeComponent();
            server = new CallServer();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        { }


        private void resetlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited
            // to true.
            resetlinkLabel.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
            //System.Diagnostics.Process.Start("C:\\Users\\Kriss\\Documents\\Scheduling\\Scheduling Interviews\\Scheduling Interviews\\Login\\ResetPage.htmll");
        }

        private void resetlinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink();
           // System.Diagnostics.Process.Start("C:\\Users\\Kriss\\Documents\\Scheduling\\Scheduling Interviews\\Scheduling_Interviews\\Login\\ResetPage.html");
        }
       // C:\Users\Kriss\Documents\Scheduling\Scheduling Interviews\Scheduling Interviews\Login\ResetPage.html
    }
}

   

