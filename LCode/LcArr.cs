using System;
using System.Collections.Generic;
using System.Text;

namespace LCode
{
    public class LcArr
    {
        /// <summary>
        /// 1. Two Sum
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int> {
                {nums[0],0 }
            };
            for (int i = 1; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (dict.ContainsKey(diff))
                {
                    return new int[] { dict[diff], i };
                }
                dict.TryAdd(nums[i],i);
            }
            return null;
        }
    }
}
