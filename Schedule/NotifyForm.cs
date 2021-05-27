using System;
using System.Collections;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using static Scheduling_Interviews.Login.ScheduleForm;
using System.Collections.Generic;

namespace Scheduling_Interviews.Schedule
{
    public partial class NotifyForm : Form
    {
        public NotifyForm()
        {
            InitializeComponent();
            listView1.View = View.Details;

            //Add Column Header

             listView1.Columns.Add("User ID", 150);
            listView1.Columns.Add("UserName", 150);
            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name", 150);
            listView1.Columns.Add("PhoneNumber,", 150);
            listView1.Columns.Add("EmailAddress", 150);

            SqlConnection con = new SqlConnection();


            String ConnectionString = ConfigurationManager.ConnectionStrings["Scheduling_Interviews.Properties.Settings.SchedulingDatabaseConnectionString"].ConnectionString;

            string sql = "SELECT UserID, UserName, FirstName, LastName,  PhoneNumber,  EmailAddress FROM Interviewee";

            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataReader Reader = cmd.ExecuteReader();

            listView1.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
                lv.SubItems.Add(Reader.GetString(5));
                listView1.Items.Add(lv);


            }

            Reader.Close();
            cnn.Close();

        }

        private String[] names = { "jayden", "Chris", "Derick", "Albert", "Abigael", "Ann", "Danson", "Grace", "Justus", "Marcus", "Vincent", "Rick" };
        private KeyPressEventArgs z;


        private void Displaycandidates()
        { }


        private void setbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var interviewdate = interviewdateTimePicker.Text;
                var stdate = DateTime.Parse(interviewdate);

               // var setdate = (DateTime.Parse(interviewdateTimePicker.Text)); //Users set date
                var nowdate = DateTime.Today;
                var nowtime = DateTime.Now;
                var starttime = starttimedateTimePicker.Value.ToShortTimeString();  // variable for time of starting interviews as selected in datetimepicker
                DateTime dt = DateTime.Parse(starttime);


                interviewdateTimePicker.CustomFormat = "dd MM yyyy";
                // starttimedateTimePicker = new DateTimePicker();

                //  DateTime  dis = starttimedateTimePicker.Text;
                //starttimedateTimePicker.CustomFormat = "HH:mm tt";
                //v


                if (stdate < nowdate)

                {
                    MessageBox.Show("Please Enter a Valid date time .");
                    return;

                }

                
                string message = "Please confirm the selection of " + interviewdateTimePicker.Text + "\t at " + starttime + " hours as the date and time set for interviews.";
                string title = "Interview Date Confirmation ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                {
                    return;
                }

                {


                    SqlConnection con = new SqlConnection();


                    String ConnectionString = ConfigurationManager.ConnectionStrings["Scheduling_Interviews.Properties.Settings.SchedulingDatabaseConnectionString"].ConnectionString;
                    SqlDataReader reader;

                    //Query
                    string sendMessage = "SELECT UserID, FirstName, LastName, UserName, PhoneNumber,  EmailAddress FROM Interviewee";

                    using (SqlConnection myConnection = new SqlConnection(ConnectionString))
                    {
                        myConnection.Open();

                        SqlCommand myCommand = new SqlCommand(sendMessage, myConnection);

                        ArrayList emails = new ArrayList();

                        reader = myCommand.ExecuteReader();

                        //var emails = new List();


                        while (reader.Read())
                        {
                            emails.Add(new EmailCode
                            {
                                Email = Convert.ToString(reader["EmailAddress"]),
                                FirstName = Convert.ToString(reader["FirstName"]),
                                LastName = Convert.ToString(reader["LastName"]),
                                username = Convert.ToString(reader["UserName"]),
                                mobile = Convert.ToString(reader["PhoneNumber"]),

                            });
                        }
                        foreach (EmailCode email in emails)
                        {
                            // Email config
                            SmtpClient smtp = new SmtpClient();
                            const string username = "cp3jkuat@gmail.com";
                            const string password = "WASCP92018";
                            SmtpClient smtpclient = new SmtpClient();
                            MailMessage mail = new MailMessage();
                            MailAddress fromaddress = new MailAddress("CP3JKUAT@GMAIL.COM", "JOMO KENYATTA");
                            smtp.Host = "smtp.gmail.com"; ;
                            smtpclient.Port = 587;
                            mail.From = fromaddress;
                            mail.To.Add(email.Email);
                            mail.Subject = ("Interview Confirmation");
                            mail.IsBodyHtml = true;
                            mail.Body = "Hi  " + HttpUtility.HtmlEncode(email.FirstName) + HttpUtility.HtmlEncode(email.LastName) + "\n CONGRATULATIONS on your succcessfull application. Your interview has been scheduled on date" + interviewdateTimePicker.Text + "as from " + starttime + "hours. \n Wishing good luck on your next stage of assessment.";
                            smtpclient.EnableSsl = true;
                            smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtpclient.Credentials = new System.Net.NetworkCredential(username, password);
                            smtpclient.Send(mail);


                            ProgressBar pBar = new ProgressBar();
                            pBar.Location = new System.Drawing.Point(20, 20);
                            pBar.Name = "Notifying Candidates";
                            pBar.Width = 200;
                            pBar.Height = 30;
                            Controls.Add(pBar);
                            {
                                pBar.Maximum = 100;
                                pBar.Step = 1;
                                pBar.Value = 0;
                                // pBar.;
                            }

                            MessageBox.Show("You have sucessfully notified the following candidates\n" + (email.FirstName));


                            
                        



                    }
                    }
                }
            }
            catch (Exception g)

            {
                MessageBox.Show(g.Message);

            }


        }

        private void interviewdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Starttimelabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // label2.Text = DateTime.Now.ToLongDateString();
            Displaycandidates();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void NotifyForm_Load(object sender, EventArgs e)
        {

            //starttimedateTimePicker = new DateTimePicker();
            //starttimedateTimePicker.Format = DateTimePickerFormat.Custom;
            //starttimedateTimePicker.CustomFormat = "HH:mm tt"; // Only use hours and minutes
            //starttimedateTimePicker.ShowUpDown = true;
        }
        public Random a = new Random(); // replace from new Random(DateTime.Now.Ticks.GetHashCode());
                                        // Since similar code is done in default constructor internally
        public List<int> randomList = new List<int>();
        int MyNumber = 0;
        private void NewNumber()
        {
            MyNumber = a.Next(0, 00001000000);
            while (randomList.Contains(MyNumber))
                MyNumber = a.Next(0, 00001000000);
            string dis = Convert.ToString(MyNumber);
            MessageBox.Show(dis);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // string list = + email.FirstName
        }
    }


}


    

