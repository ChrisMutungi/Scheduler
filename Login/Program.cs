using Scheduling_Interviews.Schedule;
using System;
using System.Windows.Forms;


namespace Scheduling_Interviews
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

          //  Application.Run(new LoginForm());
           // if (LoginForm.isLoggedIn)
           // {
               // Application.Run(new Form1());
           // }
            // Application.Run(new Login.OptionForm());
            //Application.Run(new Schedule.NotifyForm());

            //  Application.Run(new LoginForm());
            // Application.Run(new Login.ScheduleForm());
            //   Application.Run(new Login.ApplicantForm());
            //  Application.Run(new Login.SessionForm());
             Application.Run(new Schedule.ProgressForm());
            // Application.Run(new Login.ScheduleForm());
            //



        }
    }
}
