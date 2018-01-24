using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCFInstanceLib; //For Proxy Channel
using System.ServiceModel.Channels; //For Proxy Channel


namespace WCFInstanceConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Service1Client service1Client = new Service1Client();

            // 1. Create Binding
            

            WSHttpBinding wSHttpBinding = new WSHttpBinding();
            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WCFInstanceLib/Service1/");

            IService1 proxy = ChannelFactory<IService1>.CreateChannel(wSHttpBinding,endpointAddress);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(proxy.GetCounter());

            }

            Console.ReadLine();

        }
    }
}
