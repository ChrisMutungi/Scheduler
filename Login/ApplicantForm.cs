using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Scheduling_Interviews.Login
{
    public partial class ApplicantForm : Form
    {
        public ApplicantForm()
        {
            InitializeComponent();
           
        }

       

        private void ApplicantForm_Load(object sender, EventArgs e)

        {
            

            DataTable dt = new DataTable("Applicants");


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Kriss\\Documents\\Scheduling\\Scheduling Interviews\\Scheduling Interviews\\Login\\SchedulingDatabase.mdf; Integrated Security = True";
            con.Open();

            // SqlCommand cmd = new SqlCommand("SELECT * FROM Applicants", con);

            // SELECT CONCAT(Address, " ", PostalCode, " ", City) AS Address
            //FROM Customers;
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(FirstName,  ' ', LastName) AS 'Applicant Name' FROM Applicants", con);

            cmd.Connection = con;
            using (var reader = cmd.ExecuteReader())
            {

                dt.Load(reader);
                ApplicantlistBox.DataSource = dt;
                ApplicantlistBox.UseTabStops = true;

                ApplicantlistBox.DisplayMember = "FullName";
                ApplicantlistBox.ValueMember = "Applicant Name";


                ApplicantlistBox.Show();
                ApplicantlistBox.Visible = true;
                Approveallbutton.Visible = true;
                // removebutton.Visible = true;
                Approvebutton.Visible = true;

            }

            con.Close();
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
           
        }
        private void SetListBoxTabs(ListBox lst, IEnumerable<int> tabs)
        {
            // Make sure the control will use them.
            lst.UseTabStops = true;
            lst.UseCustomTabOffsets = true;

            // Get the control's tab offset collection.
            ListBox.IntegerCollection offsets = ApplicantlistBox.CustomTabOffsets;

            // Define the tabs.
            foreach (int tab in tabs)
            {
                offsets.Add(tab);
            }
        }

    }
}

   
   

