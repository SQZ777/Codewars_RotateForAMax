using System.Collections.Generic;

namespace Codewars_RotateForAMax
{
    public class Kata
    {
        public static long MaxRot(long n)
        {
            if (n.ToString().Length < 2)
                return n;
            var nString = n.ToString();
            var nChar0 = nString[1];
            var roatedN = int.Parse(nChar0 + nString.Substring(0, 1));
            if (roatedN > n)
                return roatedN;
            return n;
        }
    }
}
