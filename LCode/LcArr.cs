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
        /// <summary>
        /// 20. Valid Parentheses
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid(string s)
        {
            Stack<char> st = new Stack<char>();
            var car = s.ToCharArray();
            foreach (var c in car)
            {
                if (c == '(')
                    st.Push(')');
                else if (c == '{')
                    st.Push('}');
                else if (c == '[')
                    st.Push(']');
                else if (st.Count==0 || st.Pop() != c)
                    return false;
            }
            return st.Count == 0;
        }
        /// <summary>
        /// 53. Maximum Subarray
        /// </summary>1
        /// <param name="nums"></param>-1,-2
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            { throw new ArgumentException("nums length must more then 1"); }
            if (nums.Length == 1)
            { return nums[0]; }
            int max = nums[0], curr = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                curr = Math.Max(nums[i], curr + nums[i]);
                max = Math.Max(curr, max);
            }
            return max;
        }
    }
}
