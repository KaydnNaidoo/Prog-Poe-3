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

namespace POE3
{
    /// <summary>
    /// Interaction logic for RentHouse.xaml
    /// </summary>
    public partial class RentHouse : Window
    { 
        
        
        public RentHouse()
        {
            InitializeComponent();
        }
        //button click to go to nexk page 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show(); 

        }
        //button click to go to next page 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Car c = new Car();
            this.Close();
            c.Show(); 

        }

        //button click to submit values to array list 
        public void RentSubmit(object sender, RoutedEventArgs e) 
        {
            //instance of the class 
            Expenses exp = new Expenses(); 
            //variable 
            string HouseRent = Rent.Text;
            //converting to int32
            int rent = Convert.ToInt32(HouseRent);

           
            //adding to array list 
            exp.moneyCalc.Add(rent); 

            //showing message 
            MessageBox.Show("Your Values Have Been Added"); 

        }

      
    }
}
