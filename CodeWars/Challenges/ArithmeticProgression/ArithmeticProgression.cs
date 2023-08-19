using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.ArithmeticProgression
{
    internal class ArithmeticProgression
    {
        /// <summary>
        /// https://www.codewars.com/kata/52de553ebb55d1fca3000371
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int FindMissing(List<int> list)
        {
            int diff = (list.Last() - list.First()) / list.Count;

            for (int i = 0; i < list.Count - 1; i++)
            {
                int x = list[i];
                int y = list[i + 1];

                if (y - x != diff)
                    return x + diff;
            }

            return int.MaxValue;
        }
    }
}
