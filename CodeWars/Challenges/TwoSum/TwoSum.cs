using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Challenges.TwoSum
{
    /// <summary>
    /// https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp
    /// </summary>
    internal class TwoSums
    {
        public static int[]? TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < numbers.Length;)
            {
                for (int x = 0; x < numbers.Length;)
                {

                    if ((numbers[i] + numbers[x]) == target)
                    {
                        if (i != x)
                        {
                            result[0] = i;
                            result[1] = x;
                            return result;
                        }
                    }
                    x++;
                }
                i++;
            }
            return result;
        }
    }
}
