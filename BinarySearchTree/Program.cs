using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(12);
            binaryTree.Insert(3);
            binaryTree.Insert(15);
            binaryTree.Insert(6);
            binaryTree.Insert(9);
            binaryTree.Insert(21);

            binaryTree.Display();
            Console.WriteLine("\nBinary Tree Count = {0}", binaryTree.Count());

            Console.ReadLine();
        }
    }
}
