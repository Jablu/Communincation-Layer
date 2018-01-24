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

namespace Element_Binding_Intro
{
    /// <summary>
    /// Interaction logic for FistPage.xaml
    /// </summary>
    public partial class FistPage : Window
    {
        public FistPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string data = myData.Text;
            Application.Current.Properties.Add("data", data);
            SecondPage sp = new SecondPage();
            sp.ShowDialog();
        }
    }
}
