using System;
using System.Collections.Generic;
using System.Threading;



namespace Scheduling_Interviews
{
    class SchedulerService
    {

        public bool pause = false;
        private static SchedulerService _instance;
       // private List<Timer> timers = new List<Timer>();
        private SchedulerService() { }
        public static SchedulerService Instance => _instance ?? (_instance = new SchedulerService());
        public void status(bool pause) { this.pause=pause; }
        public void ScheduleTask(int hour, int min, double intervalInHour, Action task)
        {
            DateTime now = DateTime.Now;
            DateTime firstRun = new DateTime(now.Year, now.Month, now.Day, hour, min, 0, 0);
            if (now > firstRun)
            {
                firstRun = firstRun.AddDays(1);
            }
            TimeSpan timeToGo = firstRun - now;
            if (timeToGo <= TimeSpan.Zero)
            {
                timeToGo = TimeSpan.Zero;
            }

            var timer = new Timer(x =>
            {
                if (pause == false)
                {
                    task.Invoke();
                }
            }, null, timeToGo, TimeSpan.FromHours(intervalInHour));
            //timers.Add(timer);
        }
    }
}





