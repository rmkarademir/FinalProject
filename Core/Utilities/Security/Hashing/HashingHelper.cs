using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())//sistemin veridiği SHA512 şifreleme algoritmasını kullanıyoruz
            {
                passwordSalt = hmac.Key;//salt işlemi için sistemdeki hazır anahtarı kullanıyoruz
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//Anahtara göre password ait hash oluşturuyouz
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))//sistemin veridiği SHA512 şifreleme algoritmasını passwordSalt daki anahtara göre kullanıyoruz
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));//Anahtara göre password ait hash oluşturuyouz
                for (int i = 0; i < computedHash.Length; i++)//Hash bir arrayden oluşur, her elamanı gezerek sistemde kayıtlı hash ile şuan girilen password ait hash karşılaştırıyoruz 
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

}
