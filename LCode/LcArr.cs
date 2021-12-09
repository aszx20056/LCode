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
    }
}
