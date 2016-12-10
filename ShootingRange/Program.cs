using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingRange
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost serviceHost = new ServiceHost(typeof(SayService));

            //Thread serviceThread = new Thread(() => serviceHost.Open());
            //serviceThread.IsBackground = false;

            serviceHost.Open();

            Console.WriteLine("Service has been started");
            Console.ReadKey();

            serviceHost.Close();
        }
    }
}
