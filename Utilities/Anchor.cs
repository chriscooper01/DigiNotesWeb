using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Anchor
    {
        public static string Create(string value)
        {
            value = String.Format("{0}-{1}", value, DateTime.Now.Millisecond);
            value = Encryption.Crypt(value);
            return value;
        }
    }
}
