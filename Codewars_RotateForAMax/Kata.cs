using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Codewars_RotateForAMax
{
    public class Kata
    {
        public static long MaxRot(long n)
        {

            var resultList = new List<long> {n};
            for (var i = 0; i < n.ToString().Length - 1; i++)
            {
                var charIndex = resultList[i].ToString()[i];
                var nowString = resultList[i].ToString();
                resultList.Add(GetRotatedNumber(nowString, i, charIndex));
            }
            return resultList.Max();
        }

        private static long GetRotatedNumber(string nString, int i, char charIndex)
        {
            return int.Parse(nString.Remove(i, 1) + charIndex);
        }
    }
}
