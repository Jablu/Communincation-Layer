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
using EntitiesLib;
using EmpBusinessLayer;

namespace Element_Binding_Intro
{
    /// <summary>
    /// Interaction logic for DataGridIntro.xaml
    /// </summary>
    public partial class DataGridIntro : Window
    {
        public DataGridIntro()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BLL bLL = new BLL();
            List<Emplyoee> list = bLL.GetAllEmps();
            myDataGrid.DataContext = list;
        }
    }
}
