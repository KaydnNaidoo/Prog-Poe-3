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
    /// Interaction logic for UserWantsToSave.xaml
    /// </summary>
    public partial class UserWantsToSave : Window
    {
        public UserWantsToSave()
        {
            InitializeComponent();
        }

        //button click event to submit information 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //variables
            string saving = SavingAmt.Text;
            string interest = InterestRate.Text;
            string months = NumberOfMonths.Text;

            //instance of class expenses 
            Expenses exp = new Expenses();
            exp.SavingAMount = Convert.ToInt32(saving);
            exp.InterestRate = Convert.ToInt32(interest);
            exp.NoMonths = Convert.ToInt32(months);


            //Compound Interest A = P(1+i)^n 
            // Solving for P = (n Sqroot A) / (1+i)

            exp.USerMothlyTotal1 = (exp.NoMonths * Math.Sqrt(exp.SavingAMount))/ (1 + (exp.InterestRate * 0.01));
            
            MessageBox.Show("You will need to save up" + exp.USerMothlyTotal1 + "To get your desired outcome" +
                "/n" +
                "Your Interest Rate per Month is: " + exp.InterestRate + 
                "/n" +
                "Your Months For saving is: " + exp.SavingAMount);   
        }

        //button click to go to new page 
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show(); 
        }

        //button click to exit the app 
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }
    }
}
