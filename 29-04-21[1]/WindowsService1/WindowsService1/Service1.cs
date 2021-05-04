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
using System.IO;

namespace WindowsService1
{
    public partial class Service1 : ServiceBase
    {
        Timer timer = new Timer();
        public Service1()
        {
            InitializeComponent();
        }
        public void OnDebug()
        {
            OnStart(null);
        }
        private void OnElapsedTime(object source, ElapsedEventHandler e)
        {
            
        }

        protected override void OnStart(string[] args)
        {
            WriteToFile("service is started at " + DateTime.Now);
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 5000;
            timer.Enabled = true;

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            WriteToFile("service is recalled at" + DateTime.Now);
        }

        protected override void OnStop()
        {
            WriteToFile("service is stopped at " + DateTime.Now);
        }
        public void WriteToFile(string Message)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string filepath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\ServiceLog_" + DateTime.Now.Date.ToShortDateString().Replace('/', '_') + ".txt";
            if (!File.Exists(filepath))
            {
                // Create a file to write to.   
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(filepath))
                {
                    sw.WriteLine(Message);
                }
            }
        }

        
    }
}
