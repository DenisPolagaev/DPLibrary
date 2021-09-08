using System;
using System.Threading;

namespace DPLibrary.DPThreading.Schedule
{
    public class TimedTask
    {
        private Timer _timer;
        private readonly Action _actionToInvoke;
        private readonly Action<string> _logWriter;
        private readonly TimeSpan _intervalTime;
        private TimeSpan _startTime;

        private const int WAITING_TIME_IN_MINUTES = 1;

        private object _locker = new();

        public TimedTask(Action toInvoke, TimeSpan startTime, TimeSpan interval, Action<string> logWriter = null)
        {
            this._actionToInvoke = toInvoke;
            this._startTime = startTime;
            this._intervalTime = interval;
            this._logWriter = logWriter;
        }
        public void Start()
        {
            this.Stop();
            var timeToGo = CalculateTheFirstStartTime();
            _timer = new Timer(Callback, null, timeToGo, _intervalTime);
        }
        public void Stop()
        {
            var local = _timer;
            _timer = null;
            local?.Dispose();
        }

        private TimeSpan CalculateTheFirstStartTime()
        {
            var now = DateTime.Now;
            var firstRun = new DateTime(now.Year, now.Month, now.Day, _startTime.Hours, _startTime.Minutes, _startTime.Seconds);
            if (now > firstRun) firstRun = firstRun.AddDays(1);
            var timeToGo = firstRun - now;
            if (timeToGo <= TimeSpan.Zero) timeToGo = TimeSpan.Zero;
            return timeToGo;
        }

        private void Callback(object state)
        {
            var timeout = TimeSpan.FromMinutes(WAITING_TIME_IN_MINUTES);
            _logWriter?.Invoke($"{DateTime.Now.ToLongTimeString()} Попытка запуска");
            if (Monitor.TryEnter(_locker, timeout))
            {
                try
                {
                    _logWriter?.Invoke($"{DateTime.Now.ToLongTimeString()} Попытка успешна");
                    _logWriter?.Invoke($"{DateTime.Now.ToLongTimeString()} Запускаю задачу");
                    this._actionToInvoke();
                    _logWriter?.Invoke($"{DateTime.Now.ToLongTimeString()} Задача выполнена");

                }
                finally
                {
                    Monitor.Exit(_locker);
                }
            }
            else
            {
                _logWriter?.Invoke($"{DateTime.Now.ToLongTimeString()} Запуск не осуществлён");
            }
        }
    }
}