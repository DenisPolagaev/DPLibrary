using System;
using System.Collections.Generic;

namespace DPLibrary.DPThreading.Schedule
{
    public class Scheduler
    {
        private List<TimedTask> _tasks = new();
        
        public void ScheduleJob(Action action, TimeSpan firstRun, Action<string> logAction = null)
        {
            ScheduleJob(action, firstRun, new TimeSpan(24, 0, 0), logAction);
        }
        public void ScheduleJob(Action action, TimeSpan firstRun, TimeSpan interval, Action<string> logAction)
        {
            var task = new TimedTask(action, firstRun, interval, logAction);
            _tasks.Add(task);
            task.Start();
        }

        public void Stop()
        {
            _tasks.ForEach(t => t.Stop());
            _tasks.Clear();
        }
    }
}