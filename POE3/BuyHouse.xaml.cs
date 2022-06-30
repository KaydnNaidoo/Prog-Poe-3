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
    /// Interaction logic for BuyHouse.xaml
    /// </summary>
    public partial class BuyHouse : Window 
    {
       


        public BuyHouse()
        {
            InitializeComponent();
        }

        //button click to go to new page 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show(); 
        }

        //button click to go to car page 
        private void Car(object sender, RoutedEventArgs e)
        {
            Car c = new Car();
            this.Close();
            c.Show();  
        }

        //submitting values 
        public void HouseSubmit(object sender, RoutedEventArgs e)   
        {
            //instance of class 
            Expenses exp = new Expenses(); 

            //variables 
            string propertyrice = purchasePrice.Text;
            string Housedeposite = Deposite.Text;
            string Houseinterest = Interest.Text;
            string HouseRepay = Repay.Text;
            string homeLoan = Loan.Text;

            //converting to int
            int newProperyPrice = Convert.ToInt32(propertyrice);
            int newHouseDeposite = Convert.ToInt32(Housedeposite);
            int newHouseInterest = Convert.ToInt32(Houseinterest);
            int newHouseRepay = Convert.ToInt32(HouseRepay); 
            int newHomeLoan = Convert.ToInt32(homeLoan);

            

            //double houseTotal = newProperyPrice + newHouseDeposite + newHouseInterest + newHouseRepay + newHomeLoad;

            double houseTotal = (newProperyPrice * Math.Pow(1 + newHouseInterest / 100, newHouseRepay) ) - newHouseDeposite;    

            //adding to array list 
           exp.moneyCalc.Add(houseTotal); 
            
            //displaying message 
            MessageBox.Show("Your Values Have Been Added");

             




        }

       
    }
}
