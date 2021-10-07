using System;
using System.Threading.Tasks;

namespace AndreasReitberger.Core.Interfaces
{
    public interface IGlobalStopWatch
    {
        long StopWatchAction(Action action);
        Task<long> StopWatchActionAsync(Func<Task> function);
    }
}
