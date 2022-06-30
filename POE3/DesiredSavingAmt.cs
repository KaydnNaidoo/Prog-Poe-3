using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE3
{
       public  abstract  class DesiredSavingAmt
    {

        //getters and setters 

        private double savingAMount;
        private double interestRate;
        private double noMonths;
        private double USerMothlyTotal;  
        public double SavingAMount { get => savingAMount; set => savingAMount = value; }
        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double NoMonths { get => noMonths; set => noMonths = value; }
        public double USerMothlyTotal1 { get => USerMothlyTotal; set => USerMothlyTotal = value; }
    }
}
