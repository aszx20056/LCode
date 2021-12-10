using LCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
namespace LCodeTEST
{
    [TestClass]
    public class LcTreeTEST
    {
        LcTree lc = new LcTree();
        [TestMethod]
        public void InorderTraversal()
        {
            lc.InorderTraversal(TreeNode.Create(new int?[] { 1, null, 2, 3 })).Should().Equal(new List<int> { 1, 3, 2 });
            lc.InorderTraversal(TreeNode.Create(null)).Should().Equal(new List<int>());
            lc.InorderTraversal(TreeNode.Create(new int?[] { 1 })).Should().Equal(new List<int> { 1 });
            lc.InorderTraversal(TreeNode.Create(new int?[] { 1, 2 })).Should().Equal(new List<int> { 2,1 });
            lc.InorderTraversal(TreeNode.Create(new int?[] { 1, null, 2 })).Should().Equal(new List<int> { 1, 2 });

        }
    }
}
