using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFBookLibrary
{
    [ServiceContract]
    interface IProduct
    {

        [OperationContract]
        List<string> FindBooks(string search);

    }
}
