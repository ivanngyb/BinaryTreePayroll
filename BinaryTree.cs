using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name: Yang Beng Ng (Ivan)
//ID: 30031552
//Description: Payroll system that sorts name
//Reference: AVL Tree code is sourced from file provided my lecturer on Blackboard

namespace BinaryTreePayroll
{
    class BinaryTree
    {
        private Node root;

        public BinaryTree() { }

        public Node gsRoot
        {
            get => root;
            set => root = value;
        }

        private Node AddRecursive(Node cur, Node n)
        {
            if (cur == null)
            {
                cur = n;
                return cur;
            }
            else if (string.Compare(n.gsData, cur.gsData) < 0)
            {
                cur.gsLeft = AddRecursive(cur.gsLeft, n);
                
            }

            return cur;
        }

        private Node 
    }
}
