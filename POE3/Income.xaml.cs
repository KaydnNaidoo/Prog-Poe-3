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
    /// Interaction logic for Income.xaml
    /// </summary>
    /// 


    public partial class Income : Window
    {
        //private static double months;
        //public delegate
        public delegate void UserDelegates(double Car);

        //public List<double> moneyCalc = new List<double>();


        //global variable 
        private static double total;



        public Income()
        {
            InitializeComponent(); 
        }

        //button click to go to new page 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuyHouse bh = new BuyHouse();
            this.Close();
            bh.Show(); 
        }

        //button click to go to new page 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RentHouse rh = new RentHouse();
            this.Close();
            rh.Show(); 
        }

        //button click to go to new page 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show(); 
        }


        //Submit Button 
        public void IncomeSubmit(object sender, RoutedEventArgs e)    
        {
            //instance of class 
            Expenses exp = new Expenses(); 
            //variables
            string salary = incTB.Text;
            string taxAmt = Tax.Text;
            string groceriesAmt = Groceries.Text;
            string waterAndLightsAmt = WaterAndLights.Text;
            string travelAmt = Travel.Text;
            string otherAmt = Other.Text; 

            //converitng to Int32 
            int newIncome = Convert.ToInt32(salary); 
            int newTax = Convert.ToInt32(taxAmt);
            exp.Groceries = Convert.ToInt32(groceriesAmt);
            exp.WaterALights = Convert.ToInt32(waterAndLightsAmt);
            exp.Travel = Convert.ToInt32(travelAmt);
            exp.Luxury = Convert.ToInt32(otherAmt);  

            //calculating total 
            total = (newIncome - newTax) + exp.Groceries + exp.WaterALights + exp.Travel + exp.Luxury;
            //adding to array list 
            exp.moneyCalc.Add(total);
            //displaying message 
            MessageBox.Show("Your Values Have Been Added");







        }

    }
}
