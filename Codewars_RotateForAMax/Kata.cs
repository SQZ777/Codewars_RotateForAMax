using System.Collections.Generic;
using System.Linq;

namespace Codewars_RotateForAMax
{
    public class Kata
    {
        public static long MaxRot(long n)
        {

            var nString = n.ToString();
            var resultList = new List<long>();
            resultList.Add(n);
            for (var i = 0; i < nString.Length - 1; i++)
            {
                var charIndex = nString[i];
                resultList.Add(int.Parse(nString.Remove(i, 1) + charIndex));
                nString = nString.Remove(i, 1) + charIndex;
            }
            return resultList.Max();
        }
    }
}
