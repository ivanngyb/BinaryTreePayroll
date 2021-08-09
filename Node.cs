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
    class Node
    {
        //Node class to hold string data and nodes to its left and right
        private string data;
        private Node left, right;

        //Default constructor
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
        #region "Getters and setters"
        //Encapsulation for node class
        public string gsData
        {
            get => this.data;
            set => this.data = value;
        }

        public Node gsLeft
        { 
            get => this.left;
            set => this.left = value;
        }

        public Node gsRight
        {
            get => this.right;
            set => this.right = value;
        }
        #endregion
    }
}
