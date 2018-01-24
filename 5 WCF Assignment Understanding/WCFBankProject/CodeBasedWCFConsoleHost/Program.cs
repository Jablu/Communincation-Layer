using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using WCFBankLib;
using System.ServiceModel.Description;


namespace CodeBasedWCFConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {

            BasicHttpBinding binding = new BasicHttpBinding();

            string baseAddress = "http://localhost:8733/Design_Time_Addresses/WCFBankLib/Service1/";
            Uri uri = new Uri(baseAddress);

            //Binding and End Point HTTP
            ServiceHost svh = new ServiceHost(typeof(WCFBankLib.BankService),uri);
            svh.AddServiceEndpoint("WCFBankLib.ICustomer", binding, baseAddress);


            //Binding and End Point TCP
            NetTcpBinding netTcpBinding = new NetTcpBinding();
            svh.AddServiceEndpoint("WCFBankLib.ICustomer", netTcpBinding, "net.tcp://localhost:8001/Customer");



            ServiceMetadataBehavior metadataBehavior = new ServiceMetadataBehavior();
            metadataBehavior.HttpGetEnabled = true;

            svh.Description.Behaviors.Add(metadataBehavior);


            //start
            svh.Open();
            Console.WriteLine("Service Started! ");
            Console.WriteLine("Press Enter To Stop ");
            Console.ReadLine();

        }
    }
}
