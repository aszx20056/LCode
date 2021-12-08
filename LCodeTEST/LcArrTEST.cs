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
    }
}
