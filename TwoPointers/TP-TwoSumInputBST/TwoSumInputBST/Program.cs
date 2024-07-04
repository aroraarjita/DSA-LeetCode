namespace TwoSumInputBST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


        public bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> seen = new HashSet<int>();

            if (root is null) return false;

            if (seen.Contains(k - root.val)) return true;

            seen.Add(root.val);

            return FindTarget(root.left, k) || FindTarget(root.right, k);




    }
    }



    //Definition for a binary tree node.
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
    }

  

}
