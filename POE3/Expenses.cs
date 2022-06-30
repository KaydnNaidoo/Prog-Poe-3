using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE3
{
    class Expenses : DesiredSavingAmt  
    {

        //Getters and setters 
        public double Groceries { get; set; }
        public double WaterALights { get; set; }
        public  double Travel { get; set; }
        public  double Phone { get; set; }
        public double Luxury { get; set; }


        public List<double> moneyCalc = new List<double>();

        public List<string> CarType = new List<string>(); 

    }

    
}
