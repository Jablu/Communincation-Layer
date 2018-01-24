using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFInstanceLib
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.


        [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class Service1 : IService1
    {
            int counter = 100;
            public int GetCounter() 
            {
                counter++;
                return counter;
            }

                 public void OneWay()
                    {

                    }
    }
}
