using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsService1
{
    public class TcpServer : ServiceBase
    {

        IOCPServer iOCP;
        AsyncTCPServer TcpServerClient; 
        public override EventLog EventLog => base.EventLog;

        protected override bool CanRaiseEvents => base.CanRaiseEvents;

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public void Init()
        {
            //  TcpServerClient = new AsyncTCPServer(IPAddress.Parse("127.0.0.1"), 20002);
            iOCP = new IOCPServer(20002,1000);
            iOCP.Init();
        }
        protected override void OnStart(string[] args)
        {
            Init();
            //  TcpServerClient.Start();
            iOCP.Start();
        }
        public bool Start(string[] args)
        {
            try 
            {
                OnStart(args);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        protected override void OnStop()
        {
            //TcpServerClient.Stop();
            iOCP.Stop();
            base.OnStop();
        }
    }
}
