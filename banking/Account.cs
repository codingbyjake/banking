using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace banking {
    internal class Account {

        public string AccountId { get; set; } = string.Empty; // unique id
        public decimal Balance { get; set; } = 0;
        public string Description { get; set; } = String.Empty;

        //method to deposit amount into account
        public bool Deposit(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Amount cannot be zero or a negative number.");
                return false;
            }
            Balance += Amount;
            return true;
        }

        //method to withdraw amount from account
        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine($"Amount cannot be zero or a negative number.");
                return false;
            }
            if (Amount  > Balance) {
                Console.WriteLine($"Amount cannot excede account balance.");
                return false;
            }
            Balance -= Amount;
            return true;
        }

        //method to transfer amount to account
        public bool Transfer(decimal Amount, Account ToAccount) {           
            if (Withdraw(Amount)) {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
            //***********following code removed: refactoring #1***********
            //if (Amount <= 0) {
            //    Console.WriteLine($"Amount cannot be zero or a negative number.");
            //    return false;
            //}
            //var success = Withdraw(Amount);
            //if (!success) {
            //    return false;
            //}
        }


    }
}
