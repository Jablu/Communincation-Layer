using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;     
using WcfHello;                

namespace WCFHelloWorldConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WcfHello.HelloWorldService));
            host.Open();
            Console.WriteLine("Services Started....");
            Console.WriteLine("Press any key to stop");
            Console.ReadLine();
        }
    }
}