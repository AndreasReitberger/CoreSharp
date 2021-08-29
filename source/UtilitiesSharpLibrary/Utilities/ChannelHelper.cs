using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace AndreasReitberger.Utilities
{
    public static class ChannelHelper
    {
        static async Task GcodeHandlerAsync()
        {
            int bufferSize = 100;
            var channel = Channel.CreateBounded<object>(bufferSize);

            var reader = channel.Reader;
            var writer = channel.Writer;

            await Task.Delay(10);
        }
    }
}
