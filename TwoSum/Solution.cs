using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            List<(int num, int index)> numIndices = new List<(int num, int index)>();

            for (int i = 0; i < nums.Length; i++)
            {
                numIndices.Add((nums[i], i));
            }

            for (int i = 0; i < numIndices.Count; i++)
            {
                int complement = target - numIndices[i].num;

                for (int j = i + 1; j < numIndices.Count; j++)
                {
                    if (numIndices[j].num == complement)
                    {
                        return new int[] { numIndices[i].index, numIndices[j].index };
                    }
                }
            }

            return new int[0];
        }
    }
}
