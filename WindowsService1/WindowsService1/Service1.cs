using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();

            if(!System.Diagnostics.EventLog.SourceExists("ServiceSource"))
            {
                System.Diagnostics.EventLog.CreateEventSource("ServiceSource", "ServiceLog");
            }

            eventLog1.Source = "ServiceSource";
            eventLog1.Log = "ServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My Service Started");

            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;  // 60 seconds
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.onTimer);
            timer.Start();
        }

        private void onTimer(object sender, System.Timers.ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("Monitoring the System", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("My Service Stoped");
        }
    }
}
