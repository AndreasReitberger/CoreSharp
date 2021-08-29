using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace AndreasReitberger.Utilities
{
    public static class GlobalStopWatchInstance
    {
        static async Task StopWatchActionAsync(Func<Task> action, string LogTitle, string SourceName)
        {
            Stopwatch sw = Stopwatch.StartNew();
            await action();
            sw.Stop();
        }
    }
}
