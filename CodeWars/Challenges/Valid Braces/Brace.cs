using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.Valid_Braces
{
    public class Brace
    {
        /// <summary>
        /// https://www.codewars.com/kata/5277c8a221e209d3f6000b56
        /// </summary>
        /// <param name="braces"></param>
        /// <returns></returns>
        public static bool validBraces(String braces)
        {
            string prev = "";
            while (braces.Length != prev.Length)
            {
                prev = braces;
                braces = braces
                    .Replace("()", String.Empty)
                    .Replace("[]", String.Empty)
                    .Replace("{}", String.Empty);
            }
            return (braces.Length == 0);
        }
    }
}
