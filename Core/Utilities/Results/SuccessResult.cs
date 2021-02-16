using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) // base implemente edilen class anlamına gelir yani Result classına eşittir.
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}
