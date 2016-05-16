using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Encryption
    {
        public static string EncryptWithSalt(string value, string saltvalue)
        {
            string password = saltvalue + value;

            return Crypt(password);
        }


        public static string Crypt(string psValue)
        {
            string sValue = String.Empty;

            sValue = Convert.ToBase64String(Encoding.Unicode.GetBytes(psValue));

            return sValue;
        }

    }
}
