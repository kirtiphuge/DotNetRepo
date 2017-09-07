using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Security.Permissions;
using System.IO;

namespace FileMonitorDemo
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();

            if (!System.Diagnostics.EventLog.SourceExists("MyServiceSource2"))
            {
                System.Diagnostics.EventLog.CreateEventSource("MyServiceSource2", "MyServiceLog");
            }

            eventLog1.Source = "MyServiceSource2";
            eventLog1.Log = "MyServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("My Service Started");
            Run();
        }
        // [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]

        private void Run()
        {
            eventLog1.WriteEntry("Entry in Run");
            string path = "C:/Users/phuge_k/Desktop/Desktop/Demo";
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path=path;

            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
           | NotifyFilters.FileName | NotifyFilters.DirectoryName;

            watcher.Filter = "*.*";

            watcher.Created += new FileSystemEventHandler(OnCreate);
            watcher.Deleted += new FileSystemEventHandler(OnDelete);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.EnableRaisingEvents = true;
        }

        private void OnRenamed(object sender, RenamedEventArgs e)
        {

            string oldpath = Path.Combine(@"C:\Users\phuge_k\Desktop\Desktop\DemoCopy",e.OldName);
            string newpath = Path.Combine(@"C:\Users\phuge_k\Desktop\Desktop\DemoCopy", e.Name);

            if(File.Exists(oldpath))
            {
                File.Delete(oldpath);
            }

            File.Copy(e.FullPath,newpath,true);
            eventLog1.WriteEntry("File Renamed");
        }

        private void OnDelete(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("File deleted from Demo");
        }

        private void OnCreate(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("File Created in Demo");
            string name = e.Name;
            string path = e.FullPath;
            string destfile = Path.Combine(@"C:/Users/phuge_k/Desktop/Desktop/DemoCopy", name);
            File.Copy(path, destfile, true);

            
            eventLog1.WriteEntry("File Created in DemoCopy");




        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("My Service Stopped");
        }
    }
}
