using System;
using System.Collections.Generic;

namespace binaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TreeNode> binaryTree = new List<TreeNode>();

            TreeNode node1 = new TreeNode(1);
            TreeNode node2 = new TreeNode(2);
            TreeNode node3 = new TreeNode(3);
            TreeNode node4 = new TreeNode(4);
            TreeNode node5 = new TreeNode(5);
            TreeNode node6 = new TreeNode(6);
            TreeNode node7 = new TreeNode(7);

            node1.addLeft(node2);
            node1.addRight(node3);
            node2.addLeft(node4);
            node3.addLeft(node5);
            node3.addRight(node6);
            node5.addRight(node7);

            binaryTree.Add(node1);
            binaryTree.Add(node2);
            binaryTree.Add(node3);
            binaryTree.Add(node4);
            binaryTree.Add(node5);
            binaryTree.Add(node6);
            binaryTree.Add(node7);

            foreach (TreeNode node in binaryTree)
            {
                Console.WriteLine(node.outputNode());
            }

            node1.reverse();

            foreach (TreeNode node in binaryTree)
            {
                Console.WriteLine(node.outputNode());
            }
        }
    }

    class TreeNode
    {
        int value;
        TreeNode leftChild;
        TreeNode rightChild;

        public TreeNode(int desValue)
        {
            value = desValue;
        }

        public TreeNode(int desValue, TreeNode child1)
        {
            value = desValue;
            leftChild = child1;
        }

        public TreeNode(int desValue, TreeNode child1, TreeNode child2)
        {
            value = desValue;
            leftChild = child1;
            rightChild = child2;
        }

        public void addLeft(TreeNode left)
        {
            leftChild = left;
        }

        public void addRight(TreeNode right)
        {
            rightChild = right;
        }

        public string outputNode()
        {
            string leftVal = "!";
            string rightVal = "!";

            if (leftChild != null)
            {
                leftVal = leftChild.value.ToString();
            }

            if (rightChild != null)
            {
                rightVal = rightChild.value.ToString();
            }

            string output = value.ToString() + " - " + leftVal + " - " + rightVal;

            return output;
        }

        public void reverse()
        {
            TreeNode holder = leftChild;
            leftChild = rightChild;
            rightChild = holder;

            if (leftChild != null)
            {
                leftChild.reverse();
            }
            if (rightChild != null)
            {
                rightChild.reverse();
            }
        }
    }
}
