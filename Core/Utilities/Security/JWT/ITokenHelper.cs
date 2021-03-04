using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);// ilgili kullanıcıya ait claimlerden oluşan bir token üretir, kullanıcının giriş bilgileri doğru ise yetkisi dahilinde yapabileceği işlemleri içeren bir bilgi jetonu
    }
}
