using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.MovingZeros
{
    internal class MoveZero
    {
        /// <summary>
        /// https://www.codewars.com/kata/52597aa56021e91c93000cb0
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] MoveZeroes(int[] arr)
        {
            var zeros = arr.Where(x => x.Equals(0)).ToArray();
            List<int> list = arr.ToList();
            list.RemoveAll(x => x == 0);
            list.AddRange(zeros);
            return list.ToArray();
        }
    }
}
