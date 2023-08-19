using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.Break_camelCase
{
    internal class BreakCamel
    {
        /// <summary>
        /// https://www.codewars.com/kata/5208f99aee097e6552000148
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string BreakCamelCase(string str)
        {
            int count = 0;
            string result = str;
            foreach (char c in str) { 
            if(char.IsUpper(c))
                {
                    result = result.Insert(count, " ");
                    count++;
                }
            count++;
            }

            return result;
        }
    }
}
