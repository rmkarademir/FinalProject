using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data,string message):base(data,true,message)// data yı, işlem sonucunu ve mesajı verir.
        {

        }
        public SuccessDataResult(T data):base(data,true)// data yı ve işlem sonucunu verir.
        {

        }
        public SuccessDataResult(string message):base(default,true,message)// sadece mesajı verir.
        {

        }
        public SuccessDataResult():base(default,true)//hiçbir bilgi vermez.
        {

        }
    }
}
