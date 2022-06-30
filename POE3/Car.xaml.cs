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
    /// Interaction logic for Car.xaml
    /// </summary>
    public partial class Car : Window
    {
        //instance of class 
        Expenses exp = new Expenses();
        
        public Car()
        {
            InitializeComponent();
        }

        //button click to go to a new page 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }


        //adding values into an array list 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
           //variables 
            string make = CarMake.Text;
            string model = CarModel.Text;
            string priceCar = CarPrice.Text;
            string deposite = CarDeposite.Text;
            string interest = CarInterest.Text;


            //converting to int32 
            int newCarPrice = Convert.ToInt32(priceCar);
            int newCarDeposite = Convert.ToInt32(deposite);
            int newCarInterest = Convert.ToInt32(interest);



            //calculating car total 
            int carTotal = newCarPrice + newCarDeposite + newCarInterest;

            //adding into array lists 
            exp.moneyCalc.Add(carTotal);
            exp.CarType.Add(make); 
            exp.CarType.Add(model); 

            MessageBox.Show("Your Values Have Been Added");

          

        }

        //calculating the monthly total 
        private void MonthlyTotal(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Monthly Balance is: " + exp.moneyCalc.Sum());
            
        }

        //button click to go to anoher page 
        private void DesiredSaving(object sender, RoutedEventArgs e)
        {
            UserWantsToSave us = new UserWantsToSave();
            this.Close();
            us.Show(); 
        }
    }
} 
