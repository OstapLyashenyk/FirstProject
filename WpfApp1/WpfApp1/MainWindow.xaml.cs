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
            Window1 x = new Window1();
            x.Show();
            this.Close();
        }

        private void showInfo(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window2 x = new Window2();
            x.Show();
            this.Close();
        }

        private void cahngeInfo(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }

        private void genReport(object sender, RoutedEventArgs e)
        {

        }
    }
}
