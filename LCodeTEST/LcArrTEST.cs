using LCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
namespace LCodeTEST
{
    [TestClass]
    public class LcArrTEST
    {
        LcArr lc = new LcArr();
        [TestMethod]
        public void TwoSum()
        {
            lc.TwoSum(new int[] { 2, 7, 11, 15 }, 9).Should().Equal(new int[] {0,1 });
            lc.TwoSum(new int[] { 3, 2, 4 }, 6).Should().Equal(new int[] { 1, 2 });
            lc.TwoSum(new int[] { 3, 3 }, 6).Should().Equal(new int[] { 0, 1 });
            lc.TwoSum(new int[] { 3, 3 }, 20).Should().BeNull();
        }
        [TestMethod]
        public void IsValid()
        {
            lc.IsValid("()").Should().BeTrue();
            lc.IsValid("()[]{}").Should().BeTrue();
            lc.IsValid("(]").Should().BeFalse();
            lc.IsValid("([)]").Should().BeFalse();
            lc.IsValid("{[]}").Should().BeTrue();
            lc.IsValid("}{[]}").Should().BeFalse();
        }
        [TestMethod]
        public void MaxSubArray()
        {
            lc.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }).Should().Equals(6);
            lc.MaxSubArray(new int[] { 1 }).Should().Equals(1);
            lc.MaxSubArray(new int[] { 5, 4, -1, 7, 8 }).Should().Equals(23);
            lc.MaxSubArray(new int[] { -1, -2 }).Should().Equals(-1);
            lc.MaxSubArray(new int[] { -1, 0, 0 }).Should().Equals(-1);
            lc.MaxSubArray(new int[] { -7, -5, -4, 0 }).Should().Equals(0);
            lc.MaxSubArray(new int[] { -1, -2, -3 }).Should().Equals(-1);
        }
    }
}
