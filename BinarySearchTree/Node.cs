using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        private int number;
        public Node leftLeaf;
        public Node rightLeaf;

        public Node(int value)
        {
            number = value;
            leftLeaf = null;
            rightLeaf = null;
        }

        public void Display(Node node)
        {
            if (node == null)
            {
                return;
            }
            Display(node.leftLeaf);
            Console.Write("{0} : ", node.number);
            Display(node.rightLeaf);
        }

        public bool Search(Node node, int s)
        {
            if (node == null)
            {
                return false;
            }

            if (node.number == s)
            {
                return true;
            }
            else if (node.number < s)
            {
                return Search(node.rightLeaf, s);
            }
            else if (node.number > s)
            {
                return Search(node.leftLeaf, s);
            }
            return false;
        }

        public bool IsLeaf(ref Node node)
        {
            return (node.leftLeaf == null && node.rightLeaf == null);

        }

        public void InsertData(ref Node node, int data)
        {
            if (node == null)
            {
                node = new Node(data);

            }
            else if (node.number < data)
            {
                InsertData(ref node.rightLeaf, data);
            }
            else if (node.number > data)
            {
                InsertData(ref node.leftLeaf, data);
            }
        }



    }
}
