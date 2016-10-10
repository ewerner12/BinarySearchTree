using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTree
    {
        private Node root;
        private int count;

        public BinaryTree()
        {
            root = null;
            count = 0;
        }
        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(int input)
        {
            if (IsEmpty())
            {
                root = new Node(input);
            }
            root.InsertData(ref root, input);
            count++;
        }

        public bool IsLeaf()
        {
            if (!IsEmpty())
            {
                return root.IsLeaf(ref root);
            }
            return true;
        }

        public bool Search(int input)
        {
            return root.Search(root, input);
        }

        public void Display()
        {
            if (!IsEmpty())
            {
                root.Display(root);
            }
        }

        public int Count()
        {
            return count;
        }



    }
}
