using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFBankLib
{
    public class BankService : IManager, ICustomer
    {
        #region Manager Methods

        public string AddCustomer()
        {
            return "Customer Added Successfully.";
        }

        public string DeleteCustomer()
        {
            return "Customer Deleted Successfully.";
        }

        #endregion


        #region Customer Methods

        public string Deposite(int amount)
        {
            return "Money Deposited Successfully : " + amount ;
        }

        public string Withdraw(int amount)
        {
            return "Money Withdrawn Successfully : " + amount;
        }
        public string CheckBalance(int custid)
        {
            return "Current Balance Is 50000/- For Customer Id :" + custid;
        }
        #endregion

    }
}
