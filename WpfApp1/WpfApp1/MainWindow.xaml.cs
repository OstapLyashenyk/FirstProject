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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 d = new Window1();
            d.Show();
            this.Close();
        }

        

        private void cahngeInfo(object sender, RoutedEventArgs e)
        {
            
            Window3 x = new Window3();
            x.Show();
            this.Close();
        }

        

        private void genReport(object sender, RoutedEventArgs e)
        {

        }
    }
}
