//You are given the root of a binary search tree (BST) and an integer val.

//Find the node in the BST that the node's value equals val and return
//the subtree rooted with that node. If such a node does not exist, return null.

//        4
//       / \
//      2   7
//     / \
//    1   3

//Example 1:


//Input: root = [4, 2, 7, 1, 3], val = 2
//Output: [2, 1, 3]
//Example 2:


//Input: root = [4, 2, 7, 1, 3], val = 5
//Output: []

namespace Assignment_7._3._1
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
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(4);

            root.left = new TreeNode(2);
            root.right = new TreeNode(7);

            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            int val = 2;
            //int val = 5;
            TreeNode result = SearchBST(root, val);

            PrintTree(result);

        }
        static TreeNode SearchBST(TreeNode root,int val)
        {
            // makes a current pointer pointing at root node
            TreeNode current = root;


            while(current != null)
            {
                // if the current pointer is equal to target then returns the current pointer
                if(current.val == val)
                {
                    return current;
                } 
                // if the current value is smaller than target then move pointer to left
                else if (current.val > val)
                {
                    current = current.left;
                }
                // else that current value is larger than target then move pointer to right
                else
                {
                    current = current.right;
                }
            }
            Console.WriteLine("null");
            return null;
        }
        static void PrintTree(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.val + " ");

            // recursion to print child nodes of the target value
            // if none found break
            PrintTree(node.left);
            PrintTree(node.right);
        }
    }
}
