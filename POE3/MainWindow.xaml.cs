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

namespace POE3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            



        }
        //list view selected to go to new page  
        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Home h = new Home();
            this.Close();
            h.Show();  
        }

        //list view selected to go to new page 
        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Income i = new Income();
            this.Close();
            i.Show(); 
        }
        //list view selected to close applicaiton  
        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
