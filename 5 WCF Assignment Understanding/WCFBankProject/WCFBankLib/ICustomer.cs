using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFBankLib
{
    [ServiceContract]
    public interface ICustomer
    {
        [OperationContract]
        string Deposite(int amount);

        [OperationContract]
        string Withdraw(int amount);

        [OperationContract]
        string CheckBalance(int custid);

    }
}
