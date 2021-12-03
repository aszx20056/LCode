using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace LCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        public static ListNode Create(IList<int> vs)
        {
            if (vs == null || vs.Count()==0)
            { return null; }
            ListNode head = new ListNode(vs[0]);
            ListNode curr = head;
            for (int i = 1; i < vs.Count; i++)
            {
                ListNode n = new ListNode(vs[i]);
                curr.next = n;
                curr = curr.next;
            }
            return head;
        }
        public List<int> ToList()
        {
            List<int> res = new List<int>();
            ListNode curr = this;
            while (curr!=null)
            {
                res.Add(curr.val);
                curr = curr.next;
            }
            return res;
        }
    }
}
