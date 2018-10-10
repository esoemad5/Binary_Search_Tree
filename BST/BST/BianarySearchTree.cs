using System;
using System.Collections.Generic;
using System.Text;

namespace BST
{
    class BianarySearchTree
    {
        Node root;

        public BianarySearchTree(int data)
        {
            root = new Node(data);
        }

        public void Add(int input)
        {
            if(input <= root.Data)
            {
                if(root.Left == null)
                {
                    root.Left = new Node(input);
                }
                else
                {
                    Add(input, root.Left);
                } 
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = new Node(input);
                }
                else
                {
                    Add(input, root.Right);
                }
            }
        }
        private void Add (int input, Node currentNode)
        {
            if (input <= currentNode.Data)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new Node(input);
                }
                else
                {
                    Add(input, currentNode.Left);
                }
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = new Node(input);
                }
                else
                {
                    Add(input, currentNode.Right);
                }
            }
        }

        public bool Search(int target)
        {
            try
            {
                if (target == root.Data)
                {
                    return true;
                }
                if (target < root.Data)
                {
                    return Search(target, root.Left);
                }
                if (target > root.Data)
                {
                    return Search(target, root.Right);
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }
            

            throw new Exception("Code should never reach this statement. At root.");
        }
        private bool Search(int target, Node currentLocation)
        {
            try
            {
                if (target == currentLocation.Data)
                {
                    return true;
                }
                if (target < currentLocation.Data)
                {
                    return Search(target, currentLocation.Left);
                }
                if (target > root.Data)
                {
                    return Search(target, currentLocation.Right);
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }

            throw new Exception("Code should never reach this statement. Somewhere in the tree.");
        }

        private class Node
        {
            private int data;
            public int Data { get => data; }
            private Node left;
            public Node Left { get => left; set => left = value; }
            private Node right;
            public Node Right { get => right; set => right = value; }

            public Node(int data)
            {
                this.data = data;
            }

        }
    }
}
