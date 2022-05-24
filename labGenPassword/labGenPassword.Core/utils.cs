using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labGenPassword.Core
{
    public class Utils
    {
        public static string RandomStr(int aLenght, bool aLower, bool aUpper, bool aNumbr, bool aSpec1)
        {
            string c1 = "abcdefghiklmnopqrstuvwxyz";
            string c2 = "0123456789";
            string c3 = "[]{}<>,.;:-+#";
            //
            var x = new StringBuilder();
            var xResult = new StringBuilder();
            Random rnd = new Random();
            //
            if (aLower) x.Append(c1);
            if (aUpper) x.Append(c1.ToUpper());
            if (aNumbr) x.Append(c2);
            if (aSpec1) x.Append(c3);
            //
            if (x.ToString() == "") x.Append(c1);
            //
            while (xResult.Length < aLenght)
                xResult.Append(x[rnd.Next(x.Length)]);
            //
            return xResult.ToString();
        }
    }
}
