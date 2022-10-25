using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Proiect3.Classes
{
    internal class BankDataNormalised
    {
        public double Age { get; set; }
        public double Job { get; set; }
        public double MaritalStatus { get; set; }
        public double Education { get; set; }
        public double IsDefault { get; set; }
        public double Balance { get; set; }
        public double Housing { get; set; }
        public double Loan { get; set; }
        public double Contact { get; set; }
        public double Day { get; set; }
        public double Month { get; set; }
        public double Duration { get; set; }
        public double Campaign { get; set; }
        public double Pdays { get; set; }
        public double Previous { get; set; }
        public double Poutcome { get; set; }
        public double Outcome { get; set; }
        public override string ToString()
        {
            return Age + " " + Job + " " + MaritalStatus + " " + Education + " " + IsDefault + " " + Balance + " " + Housing + " " +
                Loan + " " + Contact + " " + Day + " " + Month + " " + Duration + " " + Campaign + " " + Pdays + " " +
                Previous + " " + Poutcome + " " + Outcome;
        }
    }
}
