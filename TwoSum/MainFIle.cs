using System;
using System.Collections.Generic;

namespace TwoSum
{
    class MainFIle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the numbers separated by space = ");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.Write("Target = ");
            int target = int.Parse(Console.ReadLine());

            Solution solution = new Solution();
            int[] result = solution.TwoSum(nums, target);
            if (result.Length > 0)
            {
                Console.Write("Indices = [{0}]", string.Join(", ", result));
            }
            else
            {
                Console.Write("No solution found.");
            }
        }
    }
}

