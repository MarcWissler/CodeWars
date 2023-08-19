using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.Unique
{
    internal class Unique
    {
        /// <summary>
        /// https://www.codewars.com/kata/585d7d5adb20cf33cb000235
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GetUnique(IEnumerable<int> numbers)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            foreach (int item in numbers)
            {
                if (keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item]++;
                }
                else
                {
                    keyValuePairs.Add(item, 1);
                }
            }
            return keyValuePairs.Where(x => x.Value == 1).ToList().FirstOrDefault().Key;
        }
    }
}
