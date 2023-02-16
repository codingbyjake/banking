using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking {
    internal class Savings : Account {

        public decimal InterestRate { get; set; } = 0.12m;

        //method to calculate interest paid per number of months
        public decimal PayInterest(int Months) {
            var interest = Balance * (InterestRate / 12) * Months;
            Deposit(interest);
            return interest;
        }
    }
}
