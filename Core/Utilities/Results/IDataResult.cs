using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult// hangi değerde döndürüleceği kullanıcıdan istenir. bu sebeple generic yapı <T> kullanılır.
    {
        T Data { get; }
    }
}
