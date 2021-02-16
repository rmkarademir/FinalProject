using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)// data yı, işlem sonucunu ve mesajı verir.
        {

        }
        public ErrorDataResult(T data) : base(data, false)// data yı ve işlem sonucunu verir.
        {

        }
        public ErrorDataResult(string message) : base(default, false, message)// sadece mesajı verir.
        {

        }
        public ErrorDataResult() : base(default, false)//hiçbir bilgi vermez.
        {

        }
    }
}
