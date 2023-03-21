using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking.Exceptions {
    internal class InsufficientFundsException : Exception {

        decimal Balance { get; set; }
        decimal Amount { get; set; }

        public InsufficientFundsException() 
            : base() { }
        public InsufficientFundsException(string Message) 
            : base(Message) { }
        public InsufficientFundsException(string Message, Exception InnerException)
            : base(Message, InnerException) { }
        public InsufficientFundsException(string Message, decimal Amount, decimal Balance)
            : base($"{Message} Amount: {Amount:C},Balance: {Balance:C}"){
            this.Balance = Balance;
            this.Amount = Amount;
        }
        }

    }

