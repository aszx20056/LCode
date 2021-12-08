using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LCode;
using FluentAssertions;

namespace LCodeTEST
{
    [TestClass]
    public class TreeNodeTEST
    {
        [TestMethod]
        public void ToList()
        {
            TreeNode ln = new TreeNode(1);
            ln.ToList().Should().Equal(new List<int?> { 1 });
            ln.left = new TreeNode(2);
            ln.ToList().Should().Equal(new List<int?> { 1,2 });
            ln.right = new TreeNode(3);
            ln.ToList().Should().Equal(new List<int?> { 1, 2,3 });
            ln = new TreeNode(1);
            ln.right = new TreeNode(3);
            ln.ToList().Should().Equal(new List<int?> { 1, null, 3 });
            ln.right.left = new TreeNode(4);
            ln.right.left.right = new TreeNode(5);
            ln.ToList().Should().Equal(new List<int?> { 1, null, 3,4,null,null,5 });
        }
        [TestMethod]
        public void Create()
        {
            TreeNode ln = TreeNode.Create(null);
            ln.Should().BeNull();
            ln = TreeNode.Create(new int?[] {1});
            ln.ToList().Should().Equal(new List<int?> { 1});
            ln = TreeNode.Create(new int?[] { 1,2 });
            ln.ToList().Should().Equal(new List<int?> { 1,2 });
            ln = TreeNode.Create(new int?[] { 1, 2,3 });
            ln.ToList().Should().Equal(new List<int?> { 1, 2,3 });
            ln = TreeNode.Create(new int?[] { 1, null, 3 });
            ln.ToList().Should().Equal(new List<int?> { 1, null, 3 });
            ln = TreeNode.Create(new int?[] { 1, null, 3, 4, null, null, 5 });
            ln.ToList().Should().Equal(new List<int?> { 1, null, 3, 4, null, null, 5 });
        }
    }
}
