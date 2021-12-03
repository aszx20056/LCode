using LCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
namespace LCodeTEST
{
    [TestClass]
    public class ListNodeTEST
    {
        [TestMethod]
        public void ToList()
        {
            ListNode ln = new ListNode(1);
            ln.ToList().Should().Equal(new List<int> { 1});
            ln.next = new ListNode(2);
            ln.ToList().Should().Equal(new List<int> { 1,2 });
            ln.next.next = new ListNode(3);
            ln.ToList().Should().Equal(new List<int> { 1, 2,3 });
        }
        [TestMethod]
        public void Create()
        {
            ListNode ln = ListNode.Create(null);
            ln.Should().BeNull();
            ln = ListNode.Create(new List<int>());
            ln.Should().BeNull();
            ln = ListNode.Create(new List<int> { 4});
            ln.ToList().Should().Equal(new List<int> { 4});
            ln = ListNode.Create(new List<int> {4,5,6 });
            ln.ToList().Should().Equal(new List<int> {4,5,6 });

        }
    }
}
