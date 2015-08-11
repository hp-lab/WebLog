using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLog.Hubs
{
    public class LogHub : Hub
    {

        private static LogHub instance = null;

        public LogHub()
        {
            instance = this;
        }

        public static void PublishLog(string level, string message)
        {
            if (instance == null) return;
            instance.Clients.All.log(level, message);
        }

        public void Log(string level, string message)
        {
            Clients.All.log(level, message);
        }
    }
}
