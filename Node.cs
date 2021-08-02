using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreePayroll
{
    class Node
    {
        private string data;
        private Node left, right;

        public Node() { }
        public Node(string data) 
        {
            this.data = data;
        }
        public Node(string data, Node left, Node right) 
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }
    }
}
