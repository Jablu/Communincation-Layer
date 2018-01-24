using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using EmpBusinessLayer;
using EntitiesLib;

namespace WpfAppIntro
{
    /// <summary>
    /// Interaction logic for ListView.xaml
    /// </summary>
    public partial class ListView2 : Window
    {
        public ListView2()
        {
            InitializeComponent();
        }

       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //List<Employee> list = new List<Employee>
            //{

            //    new Employee{Ecode=1,Ename="x",Salary=1,Deptid=1},
            //    new Employee{Ecode=1,Ename="x",Salary=1,Deptid=1},
            //    new Employee{Ecode=1,Ename="x",Salary=1,Deptid=1},
            //    new Employee{Ecode=1,Ename="x",Salary=1,Deptid=1}

            //};

          
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            BLL bll = new BLL();

            List<Emplyoee> list = bll.GetAllEmps();
            myListView.ItemsSource = list;
        }
    }
}
