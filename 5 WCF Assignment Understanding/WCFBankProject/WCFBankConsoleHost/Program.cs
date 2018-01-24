using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel; //For Service Host
using WCFBankLib; //For Service Class

namespace WCFBankConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost serviceHost = new ServiceHost(typeof(WCFBankLib.BankService));
            serviceHost.Open();
            Console.WriteLine("Bank Service Started. . . ");
            Console.WriteLine("Press Enter Key To Stop. . . ");
            Console.ReadLine();


        }
    }
}
