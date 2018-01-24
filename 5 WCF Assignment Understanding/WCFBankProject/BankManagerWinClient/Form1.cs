using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagerWinClient.ServiceReference1;


namespace BankManagerWinClient
{
    public partial class Form1 : Form //For Proxy
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManagerClient managerClient = new ManagerClient();
            MessageBox.Show(managerClient.AddCustomer());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ManagerClient managerClient = new ManagerClient();
            MessageBox.Show(managerClient.DeleteCustomer());

        }
    }
}
