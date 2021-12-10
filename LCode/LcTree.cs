using System;
using System.Collections.Generic;
using System.Text;

namespace LCode
{
    public class LcTree
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
     
            List<int> res = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            TreeNode curr = root;
            while (curr!=null || st.Count>0)
            {
                while (curr!=null)
                {
                    st.Push(curr);
                    curr = curr.left;
                }
                curr = st.Pop();
                res.Add(curr.val);
                curr = curr.right;
            }
            return res;
        }
        private void InorderTraversal_SUB(TreeNode root,List<int> res)
        {
            if (root == null)
            { return; }
            InorderTraversal_SUB(root.left, res);
            res.Add(root.val);
            InorderTraversal_SUB(root.right, res);
        }
    }
}
