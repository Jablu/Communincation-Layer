using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;
using System.ServiceModel;


namespace WCFConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svh = new ServiceHost(typeof(WcfServiceLibrary.HelloWorldServices));
            svh.Open();
            Console.WriteLine("Service Started. . . ");
            Console.WriteLine("Press to stop. . .");
            Console.ReadLine();

        }
    }
}
