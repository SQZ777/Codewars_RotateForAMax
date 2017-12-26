using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Codewars_RotateForAMax
{
    public class Kata
    {
        public static long MaxRot(long n)
        {
            var resultList = new List<long> { n };
            var nString = n.ToString();
            for (var i = 0; i < nString.Length; i++)
            {
                nString += nString[i];
                nString = nString.Remove(i, 1);
                resultList.Add(long.Parse(nString));
            }
            return resultList.Max();
        }
    } 
}
