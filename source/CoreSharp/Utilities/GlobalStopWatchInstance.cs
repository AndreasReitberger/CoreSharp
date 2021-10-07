using AndreasReitberger.Core.Interfaces;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AndreasReitberger.Core.Utilities
{
    public class GlobalStopWatchInstance : IGlobalStopWatch
    {
        public long StopWatchAction(Action action)
        {
            Stopwatch sw = Stopwatch.StartNew();
            action?.Invoke();
            //await action();
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }

        public async Task<long> StopWatchActionAsync(Func<Task> function)
        {
            Stopwatch sw = Stopwatch.StartNew();
            await function();
            sw.Stop();
            return sw.ElapsedMilliseconds;
        }
    }
}
