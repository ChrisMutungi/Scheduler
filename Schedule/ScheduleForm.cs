using System;
using System.Collections;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Scheduling_Interviews.Schedule;

namespace Scheduling_Interviews.Login
{
    public partial class ScheduleForm : Form
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["Scheduling_Interviews.Properties.Settings.SchedulingDatabaseConnectionString"].ConnectionString;
        public class EmailCode
        {
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string username { get; set; }
            public string mobile { get; set; }

        }

        private void ScheduleForm_Load(object sender, EventArgs e)

        { }

        public ScheduleForm()
        {
            InitializeComponent();

            // this.listView1.Items[].Focused = true;
            listView1.View = View.Details;

            //Add Column Header

            //listView1.Columns.Add("User ID", 150);
            listView1.Columns.Add("UserName", 150);
            listView1.Columns.Add("First Name", 150);
            listView1.Columns.Add("Last Name", 150);
            listView1.Columns.Add("PhoneNumber,", 150);
            listView1.Columns.Add("EmailAddress", 150);
            listView1.Columns.Add("Status", 150);
            SqlConnection con = new SqlConnection();


            String ConnectionString = ConfigurationManager.ConnectionStrings["Scheduling_Interviews.Properties.Settings.SchedulingDatabaseConnectionString"].ConnectionString;

            string sql = "SELECT UserName, FirstName, LastName,  PhoneNumber,  EmailAddress, Status FROM Applicants";

            SqlConnection cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sql, cnn);
            //cmd.ExecuteNonQuery();
            //SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            SqlDataReader Reader = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //adpt.Fill(dt);
            //dataGridView1.DataSource = dt;
            listView1.Items.Clear();

            while (Reader.Read())
            {

                ListViewItem lv = new ListViewItem(Reader.GetString(0));
                lv.SubItems.Add(Reader.GetString(1));
                lv.SubItems.Add(Reader.GetString(2));
                lv.SubItems.Add(Reader.GetString(3));
                lv.SubItems.Add(Reader.GetString(4));
               lv.SubItems.Add(Reader.GetString(5));
               // lv.SubItems.Add(Reader.GetString(5));
                listView1.Items.Add(lv);
                //Reader.GetInt32(0).ToString()

            }

            Reader.Close();
            
            cnn.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Removebutton_Click(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Singlecopy();
        }

        private void setbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NotifyForm notform = new NotifyForm();
            notform.Show();
            //Application.Run(new Login.SessionForm());

        }





        private void candidateslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void approveallbutton_Click(object sender, EventArgs e)
        {

            //  BulkCopy();

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
        
    

        private void Singlecopy()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename= C:\\Users\\Kriss\\Documents\\Scheduling\\Scheduling Interviews\\Scheduling Interviews\\Login\\SchedulingDatabase.mdf;Integrated Security=True";
            
            conn.Open();

            using (SqlConnection sourceConnection = new SqlConnection(ConnectionString))

            {
                sourceConnection.Open();

                // Perform an initial count on the destination table.
                SqlCommand commandRowCount = new SqlCommand("SELECT COUNT(*) FROM " + "dbo.Applicants;", sourceConnection);



                long countStart = System.Convert.ToInt32(commandRowCount.ExecuteScalar());
                string dis = countStart.ToString();


                MessageBox.Show("Starting row count is  " + dis);

                // Get data from the source table as a SqlDataReader.
                SqlCommand commandSourceData = new SqlCommand("SELECT UserID,UserName, FirstName, MiddleName,LastName, PhoneNumber, EmailAddress, IdNumber, Nationality FROM Applicants;", sourceConnection);

                SqlDataReader reader = commandSourceData.ExecuteReader();

                // Open the destination connection. In the real world you would
                // not use SqlBulkCopy to move data from one table to the other
                // in the same database. This is for demonstration purposes only.
                using (SqlConnection destinationConnection = new SqlConnection(ConnectionString))
                {
                    destinationConnection.Open();

                    // Set up the bulk copy object.
                    // Note that the column positions in the source
                    // data reader match the column positions in
                    // the destination table so there is no need to
                    // map columns.
                    using (SqlBulkCopy bulkCopy = new SqlBulkCopy(destinationConnection))

                    {
                        bulkCopy.DestinationTableName = "dbo.Interviewee";


                        try
                        {

                            // Write from the source to the destination.
                            bulkCopy.WriteToServer(reader);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                            //  Console.WriteLine(ex.Message);
                        }
                        finally
                        {
                            // Close the SqlDataReader. The SqlBulkCopy
                            // object is automatically closed at the end
                            // of the using block.
                            reader.Close();
                        }
                    }

                    // Perform a final count on the destination
                    // table to see how many rows were added.

                    long countEnd = System.Convert.ToInt32(commandRowCount.ExecuteScalar());
                    var endrow = countEnd.ToString();

                    MessageBox.Show("Ending row count = " + endrow);
                    var dif = countEnd - countStart;
                    MessageBox.Show(dif + "rows were added.", dif.ToString());



                    //Console.WriteLine("Ending row count = {0}", countEnd);
                    //  Console.WriteLine("{0} rows were added.", countEnd - countStart);
                    // Console.WriteLine("Press Enter to finish.");
                    // Console.ReadLine();
                    //}
                }
            }
        }

        private static string GetConnectionString()
        // To avoid storing the sourceConnection string in your code,
        // you can retrieve it from a configuration file.
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename= C:\\Users\\Kriss\\Documents\\Scheduling\\Scheduling Interviews\\Scheduling Interviews\\Login\\SchedulingDatabase.mdf;Integrated Security=True";
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mes = listView1.SelectedItems[0];
            var q = mes.SubItems[4].Text;

            MessageBox.Show(q.ToString());


        }
    }

    
}