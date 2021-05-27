using System;
using System.Collections;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Net.Mail;
using System.Web;
using static Scheduling_Interviews.Login.ScheduleForm;


namespace Scheduling_Interviews.Login
{
    public partial class SessionForm : Form
    {
        private int selected;
        private bool pause=false;
        int counter;
        public SessionForm()
        {
            counter = 0;
            InitializeComponent();
        }
        
        private String[] names = { "jayden", "Chris", "Derick", "Albert", "Abigael", "Ann", "Danson", "Grace", "Justus", "Marcus", "Vincent", "Rick" };
        private KeyPressEventArgs z;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void hourcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //  hourcomboBox.DropDownStyle = ComboBoxStyle.DropDown;
        //   hourcomboBox_KeyPress(sender, e);

        }
      

        private void hourcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void setbutton_Click(object sender, EventArgs e)
        {
            try
            {
                

                var hours = (hourcomboBox.Text);
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


                this.Hide();
                Schedule.ProgressForm prg = new Schedule.ProgressForm();
                prg.Show();

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
                             if (counter < names.Length)
                             {
                                 string mess = "My name is " + names[counter];
                                 MessageBox.Show(mess);
                             }

                             MessageBox.Show("Names are over...");
                
                            // button2_Click(sender, e); 
                             checkMails();
                            
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
                    selected=2;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      //  public void interviewCandidates()
        

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void sessionlabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void durationcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datelabel_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }

       
    }


