using System;
using System.Collections;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Web;
using System.Drawing;
using TarmacSystem;
using static Scheduling_Interviews.Login.ScheduleForm;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;


namespace Scheduling_Interviews.Schedule
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        private ViewClass viewClass;
        private int selected;
        private bool pause = false;
        int counter;

        public Form1()

        {
            InitializeComponent();
            counter = 0;
            viewClass = new ViewClass();
            dt = viewClass.GetAllApplications();
            dgvApplications.DataSource = dt;
            listView1.View = View.Details;

            //Add Column Header

            listView1.Columns.Add("User ID", 150);
            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name", 150);
            listView1.Columns.Add("Email Address", 150);
            listView1.Columns.Add("Phone Number,", 150);
           // listView1.Columns.Add("EmailAddress", 150);
            SqlConnection con = new SqlConnection();



          SqlConnection cnn =  new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kriss\Documents\Applications.mdf;Integrated Security=True;Connect Timeout=30");
        

            string sql = "SELECT id, firstName, lastName, email,  PhoneNo, gender, maritalStatus FROM AllApplications";

            //SqlConnection cnn = new SqlConnection(sq);
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
        ArrayList lst = new ArrayList();
      //  private String[] names = { "jayden", "Chris", "Derick", "Albert", "Abigael", "Ann", "Danson", "Grace", "Justus", "Marcus", "Vincent", "Rick" };
        private KeyPressEventArgs z; 

        private void setbutton_Click(object sender, EventArgs e)
        {

        }
    

   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShortlist_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvApplications.SelectedRows;
            foreach (var row in selectedRow)
            {
                dgvShortlisted.DataSource = viewClass.Shortlist((((DataGridViewRow)row).Cells[2].Value).ToString());
            }
            dgvApplications.DataSource = viewClass.GetAllApplications();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            {
                var selectedRow = dgvApplications.SelectedRows;

                foreach (var row in selectedRow)
                {
                    if ((((DataGridViewRow)row).Cells[7].Value).ToString() != "")
                    {
                        var opening = viewClass.GetFyles((((DataGridViewRow)row).Cells[2].Value).ToString());
                        File.WriteAllBytes(opening.fileName, opening.fileData);
                        System.Diagnostics.Process.Start(opening.fileName);
                    }
                    else
                    {
                        MessageBox.Show("Üser has no file uploaded");
                    }

                }

            }

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            viewClass.DeleteApplication();
            dgvApplications.DataSource = viewClass.GetAllApplications();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            {
                dgvShortlisted.DataSource = viewClass.GetAllShortlisted();
                dgvApplications.DataSource = viewClass.GetAllApplications();
            }
        }

        private void dgvApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var selectedRow = dgvApplications.SelectedRows;

                foreach (var row in selectedRow)
                {
                    if ((((DataGridViewRow)row).Cells[7].Value).ToString() != "")
                    {
                        var opening = viewClass.GetFyles((((DataGridViewRow)row).Cells[2].Value).ToString());
                        File.WriteAllBytes(opening.fileName, opening.fileData);
                        System.Diagnostics.Process.Start(opening.fileName);
                    }
                    else
                    {
                        MessageBox.Show("Üser has no file uploaded");
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        private void setbutton_Click_1(object sender, EventArgs e)
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


                // interviewdateTimePicker.CustomFormat = "dd MM yyyy";
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

               else  {


                    SqlConnection con = new SqlConnection();

                    SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kriss\Documents\Applications.mdf;Integrated Security=True;Connect Timeout=30");



                    string sendMessage = "SELECT id, firstName, lastName, email,  PhoneNo FROM AllApplications";


                   // String ConnectionString = ConfigurationManager.ConnectionStrings["Scheduling_Interviews.Properties.Settings.SchedulingDatabaseConnectionString"].ConnectionString;
                    SqlDataReader reader;


                    //Query
                    //string sendMessage = "SELECT UserID, FirstName, LastName, UserName, PhoneNumber,  EmailAddress FROM Interviewee";

                    using (SqlConnection myConnection = cnn)
                    {
                        myConnection.Open();

                        SqlCommand myCommand = new SqlCommand(sendMessage, myConnection);

                        ArrayList emails = new ArrayList();

                        reader = myCommand.ExecuteReader();

                        //var emails = new List();
                       // string[] arr = new string[5];

                        while (reader.Read())
                        {
                            lst.Add(Convert.ToString(reader["email"]));
                            emails.Add(new EmailCode
                            {
                                Email = Convert.ToString(reader["email"]),
                                FirstName = Convert.ToString(reader["firstName"]),
                                LastName = Convert.ToString(reader["lastName"]),
                                //username = Convert.ToString(reader["UserName"]),
                                mobile = Convert.ToString(reader["PhoneNo"]),
                        });
                           

                        }
                        foreach (EmailCode email in emails)
                        {
                            // Email config
                            
                   
                            SmtpClient smtp = new SmtpClient();
                            const string username = "cp3jkuat@gmail.com";
                            const string password = "WASCP92018";
                           

                            //const string password = "WASCP92018";
                            SmtpClient smtpclient = new SmtpClient();
                            MailMessage mail = new MailMessage();
                            MailAddress fromaddress = new MailAddress("CP3JKUAT@GMAIL.COM", "JOMO KENYATTA");
                            smtp.Host = "smtp.gmail.com"; ;
                            smtpclient.Port = 587;
                            
                            mail.From = fromaddress;
                            mail.To.Add(email.Email);
                            mail.Subject = ("Interview Confirmation");
                            mail.IsBodyHtml = true;
                            mail.Body = "Hi  " + HttpUtility.HtmlEncode(email.FirstName) + HttpUtility.HtmlEncode(email.LastName) + "\n CONGRATULATIONS on your succcessfull application. Your interview has been scheduled on " + interviewdateTimePicker.Text + "as from " + starttime + "hours. \n Wishing good luck on your next stage of assessment.";
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
        private void checkMails()
        {
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



                while (reader.Read())
                {
                    string Email = Convert.ToString(reader["EmailAddress"]);
                    MessageBox.Show(Email);

                }




                myConnection.Close();


            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {

        }
        //public bool status(bool pause) { return pause; }
        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                if (pause == false)
                {

                    pause = true;
                    button2.Text = "Resume";
                }
                else
                {
                    pause = false;
                    button2.Text = "Hold";
                }
                MyScheduler.status(pause);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Kriss\Documents\Applications.mdf;Integrated Security=True;Connect Timeout=30");

            string sql = "SELECT  firstName, lastName, email FROM AllApplications";

            using (SqlConnection myConnection = cnn)
            {
                myConnection.Open();

                SqlCommand myCommand = new SqlCommand(sql, cnn);

                ArrayList emails = new ArrayList();
                SqlDataReader reader;

                reader = myCommand.ExecuteReader();

                //var emails = new List();
                // string[] arr = new string[5];

                while (reader.Read())
                {
                    lst.Add(Convert.ToString(reader["firstName"])+" "+ (Convert.ToString(reader["lastName"])) );
                    
                    

                }


                try
                {


                    var hours = (hourcombo1Box.Text);
                    var minutes = (minutecomboBox.Text);

                    if (string.IsNullOrEmpty(hourcomboBox.Text) || string.IsNullOrEmpty(minutecomboBox.Text) || string.IsNullOrEmpty(durationcomboBox.Text))
                    {
                        MessageBox.Show("Please fill all the required details");
                        //minutecomboBox.SelectedItem == null || durationcomboBox.SelectedItem == null)
                        return;
                    }


                    int phours = (int.Parse(hourcomboBox.Text)); //selected time (hours)
                    int pminutes = (int.Parse(minutecomboBox.Text)); //Selected time(minutes)
                    var hr = DateTime.Now.Hour;  // current time(hour)
                    var min = DateTime.Now.Minute;
                    var setdate = (DateTime.Parse(dateTimePicker1.Text)); //Users set date
                    var nowdate = DateTime.Today;

                    if (phours < hr || pminutes <= min || setdate != nowdate)
                    {
                        MessageBox.Show("Please enter valid time");
                        return;
                    }


                    

                    if (selectcomboBox.SelectedItem.ToString() == "Seconds")
                    {
                        selected = 0;
                        int minute = (int.Parse(minutecomboBox.Text));
                        int hour = (int.Parse(hourcomboBox.Text));
                        double interval = double.Parse(durationcomboBox.Text);
                        string message = "Please confirm the selection of " + hours + ":" + minutes + " Hours and at an Interval of " + interval + "Seconds each";
                        string title = "Confirmation Window";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        MessageBox.Show("You Have successfully Scheduled the interviews Starting From" + hours + ":" + minutes + " At an Interval Of " + interval + "Seconds" + "\n Press Ok to confirm");

                        if (result == DialogResult.Yes)
                        {
                            this.Hide();
                            Schedule.ProgressForm prg = new Schedule.ProgressForm();
                            prg.Show();

                            // listUserControl lct1;
                            // lct1 = new listUserControl();
                            // Controls.Add(lct1);
                            // lct1.Show();
                            // lct1.BringToFront();
                            // lct1.BringToFront();
                            // this.Hide();
                            MyScheduler.IntervalInSeconds(hour, minute, interval,
                             () =>
                             {

                                 var next = counter;
                                 counter = next + 1;
                                 if (counter < lst.Count)
                                 {
                                     string mess = "Now interviewing  " + lst[counter];
                                     MessageBox.Show(mess);
                                 }

                               


                                 // button2_Click(sender, e); 
                               //  checkMails();

                             });
                        }

                        if (result == DialogResult.Cancel)
                        {
                            this.Close();
                        };

                        if (result == DialogResult.No)
                        {

                        }

                    }

                    if (selectcomboBox.SelectedItem.ToString() == "Minutes")
                    {
                        selected = 1;
                        double interval = double.Parse(durationcomboBox.Text);

                        string message = "Please confirm the selection of " + hours + ":" + minutes + " Hours and at an Interval of " + interval + "Minutes each";
                        string title = "Confirmation Window";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("You Have successfully Scheduled the interviews Starting From" + hours + ":" + minutes + " At an Interval Of " + interval + "Minutes");

                            int minute = (int.Parse(minutecomboBox.Text));
                            int hour = (int.Parse(hourcomboBox.Text));
                            MyScheduler.IntervalInMinutes(hour, minute, interval,
                              () =>
                              {
                                  string mess = " success kriss Minutes";
                                  MessageBox.Show(mess);
                              });

                        }

                        if (result == DialogResult.Cancel)
                        {
                            this.Close();
                        };

                        if (result == DialogResult.No)
                        {

                        }

                    }

                    if (selectcomboBox.SelectedItem.ToString() == "Hours")
                    {
                        selected = 2;
                        double interval = double.Parse(durationcomboBox.Text);

                        string message = "Please confirm the selection of " + hours + ":" + minutes + " Hours and at an Interval of " + interval + "Hours each";
                        string title = "Confirmation Window";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNoCancel;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            MessageBox.Show("You Have successfully Scheduled the interviews Starting From " + hours + " : " + minutes + " At an Interval Of " + interval + "Hours");

                            int minute = (int.Parse(minutecomboBox.Text));
                            int hour = (int.Parse(hourcomboBox.Text));
                            MyScheduler.IntervalInHours(hour, minute, interval,
                              () =>
                              {

                                  string mess = " success kriss Hours";
                                  MessageBox.Show(mess);

                              });

                        }

                        if (result == DialogResult.Cancel)
                        {
                            this.Close();
                        };

                        if (result == DialogResult.No)
                        {

                        }

                    }
                }

                catch (Exception g)

                {
                    MessageBox.Show(g.Message);

                }
            }
        }
        private void hourcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void selectcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            durationcomboBox.Items.Clear();

            if (selectcomboBox.SelectedItem.ToString() == "Seconds")
            {
                durationcomboBox.Items.Add("5");
                durationcomboBox.Items.Add("10");
                durationcomboBox.Items.Add("20");
                durationcomboBox.Items.Add("30");
                durationcomboBox.Items.Add("40");
                durationcomboBox.Items.Add("50");
                durationcomboBox.Items.Add("60");

            }


            else if (selectcomboBox.SelectedItem.ToString() == "Minutes")
            {
                durationcomboBox.Items.Add(" 01");
                durationcomboBox.Items.Add(" 05");
                durationcomboBox.Items.Add(" 10");
                durationcomboBox.Items.Add(" 15");
                durationcomboBox.Items.Add("20");
                durationcomboBox.Items.Add(" 25");
                durationcomboBox.Items.Add("30");
                durationcomboBox.Items.Add(" 35");
                durationcomboBox.Items.Add("40");
                durationcomboBox.Items.Add(" 45");
                durationcomboBox.Items.Add("50");
                durationcomboBox.Items.Add(" 55");
            }
            else if (selectcomboBox.SelectedItem.ToString() == "Hours")
            {
                durationcomboBox.Items.Add("1");
                durationcomboBox.Items.Add("1.5");
                durationcomboBox.Items.Add("2");
                durationcomboBox.Items.Add("2.5");
                durationcomboBox.Items.Add("3");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void hourcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

  