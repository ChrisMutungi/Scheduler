using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling_Interviews.Login
{
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        private void sessiontabPage_Click(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {

        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            if (sessiontabControl.SelectedTab == scheduletabPage)
            { 
            this.Hide();
            ScheduleForm sf = new ScheduleForm();
            sf.Show();
        }
            if (sessiontabControl.SelectedTab == sessiontabPage)
            {
                this.Hide();
                SessionForm sef = new SessionForm ();
                sef.Show();
            }
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void scheduletabPage_Click(object sender, EventArgs e)
        {

        }
    }

      //  private void sessiontabControl_SelectedIndexChanged(object sender, EventArgs e)
       

        //private void scheduletabPage_Click(object sender, EventArgs e)
       
    }

