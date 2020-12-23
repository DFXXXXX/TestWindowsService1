using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace TestWindowsService1
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new TcpServer()
            };

            if (Environment.UserInteractive)
            {
                TcpServer service1 = new TcpServer();
                service1.Init();
                    if (!service1.Start(new string[] { "-r" }))
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        //EXE方式运行，永久暂停主线程
                        System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
                    }
            }
            else
            {
                // Put the body of your old Main method here.  
            }
            ServiceBase.Run(ServicesToRun);
        }
    }
}
