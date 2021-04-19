using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Business
{
    public class SecurityHelper
    {
        // salt maken
        public static String GenerateSalt(String gebruikersnaam)
        {
            var saltBytes = new byte[gebruikersnaam.Length*70];
            return Convert.ToBase64String(saltBytes);
        }

        // password encrypten met salt.
        public static String ConvertToEncrypt(String password, String salt, int nIterations, int nHash)
        {
            var saltBytes = Convert.FromBase64String(salt);

            using (var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, nIterations))
            {
                return Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(nHash));
            }
        }
    }
}