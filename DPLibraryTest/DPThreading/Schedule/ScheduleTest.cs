using System;
using DPLibrary.DPThreading.Schedule;
using NUnit.Framework;

namespace DPLibraryTest.DPThreading.Schedule
{
    [TestFixture]
    public class ScheduleTest
    {
        [Test]
        public void Test()
        {
            var scheduler = new Scheduler();
            Action<string> log = Console.WriteLine; // Optional
            Action execute = () => { /* code */ };
            TimeSpan startTime = new TimeSpan(12, 54, 30);
            TimeSpan interval = new TimeSpan(0, 4, 0); // Optional
            scheduler.ScheduleJob(execute,startTime , interval, log);
        }
    }
}