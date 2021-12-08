using System;
using System.Collections.Generic;
using System.Text;

namespace LCode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public static TreeNode Create(IList<int?> vs)
        {
            if (vs == null || vs.Count == 0 || vs[0]==null)
            {
                return null;
            }
            Queue<TreeNode> qt = new Queue<TreeNode>();
            TreeNode res = new TreeNode(vs[0].Value);
            qt.Enqueue(res);
            int c = 1;
            while (qt.Count>0 && vs.Count>c)
            {
                TreeNode curr = qt.Dequeue();
                if (vs[c].HasValue)
                {
                    curr.left = new TreeNode(vs[c].Value);
                    qt.Enqueue(curr.left);
                }
                c++;
                if (c == vs.Count)
                { break; }
                if (vs[c].HasValue)
                {
                    curr.right = new TreeNode(vs[c].Value);
                    qt.Enqueue(curr.right);
                }
                c++;
            }
            return res;
        }
        public List<int?> ToList()
        {
            List<int?> res = new List<int?>();
            Queue<TreeNode> qt = new Queue<TreeNode>();
            qt.Enqueue(this);
            res.Add(val);
            while (qt.Count>0)
            {
                int Tsize = qt.Count;
                List<int?> sub = new List<int?>();
                for (int i = 0; i < Tsize; i++)
                {
                    TreeNode curr = qt.Dequeue();
                    if (curr.left == null && curr.right == null)
                    { continue; }
                    if (curr.left != null)
                    {
                        qt.Enqueue(curr.left);
                        sub.Add(curr.left.val);
                    }
                    else {
                        sub.Add(null);
                    }
                    if (curr.right != null)
                    {
                        qt.Enqueue(curr.right);
                        sub.Add(curr.right.val);
                    }
                    else {
                        sub.Add(null);
                    }
                }
                //claer null
                if (sub.Count > 0)
                {
                
                    res.AddRange(sub);
                }
            }
            int lastNotNull = res.FindLastIndex(x => x.HasValue) + 1;
            if (lastNotNull > 0 && lastNotNull != res.Count)
            {
                res.RemoveRange(lastNotNull, res.Count - lastNotNull);
            }
            return res;
        }
    }
}
