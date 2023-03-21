using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banking.Exceptions {
    internal class CantBeZeroException : Exception {

        public CantBeZeroException()
            : base(){}
        public CantBeZeroException(string message) 
            : base(message) { }
        public CantBeZeroException(string message, Exception innerException) 
            : base(message, innerException) { }

    }
}
