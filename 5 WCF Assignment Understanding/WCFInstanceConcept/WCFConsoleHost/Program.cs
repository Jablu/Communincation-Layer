using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFInstanceLib;


namespace WCFConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(WCFInstanceLib.Service1));
            serviceHost.Open();
            Console.WriteLine("Service started");
            Console.WriteLine("Enter to exit!");
            Console.ReadLine();
        }
    }
}
