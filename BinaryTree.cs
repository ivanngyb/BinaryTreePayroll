using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        //Adding new data into AVL tree and rebalances using BalanceTree() and Rotate methods
        public void Add(string data)
        {
            Node newItem = new Node(data);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                root = AddRecursive(root, newItem);
            }
        }

        //Binary tree adds data in recursively
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
                cur = BalanceTree(cur);
            }
            else if (string.Compare(n.gsData, cur.gsData) > 0)
            {
                cur.gsRight = AddRecursive(cur.gsRight, n);
                cur = BalanceTree(cur);
            }

            return cur;
        }

        //Tree gets balanced
        private Node BalanceTree(Node cur)
        {
            int bFactor = BalanceFactor(cur);
            if (bFactor > 1)
            {
                if (BalanceFactor(cur.gsLeft) > 0)
                {
                    cur = RotateLL(cur);
                }
                else
                {
                    cur = RotateLR(cur);
                }
            }
            else if (bFactor < -1)
            {
                if (BalanceFactor(cur.gsRight) > 0)
                {
                    cur = RotateRL(cur);
                }
                else
                {
                    cur = RotateRR(cur);
                }
            }
            return cur;
        }

        //When data gets deleted the tree automatically balances itself
        public void Delete(string target)
        {
            root = DeleteNode(root, target);
        }

        private Node DeleteNode(Node cur, string target)
        {
            Node parent;

            if (cur == null)
            {
                return null;
            }
            else
            {
                string lowTarget = target.ToLower();
                string lowData = cur.gsData.ToLower();
                //Left subtree
                if (string.Compare(lowTarget, lowData) < 0)
                {
                    cur.gsLeft = DeleteNode(cur.gsLeft, target);
                    if (BalanceFactor(cur) == -2)
                    {
                        if (BalanceFactor(cur.gsRight) <= 0)
                        {
                            cur = RotateRR(cur);
                        }
                        else
                        {
                            cur = RotateRL(cur);
                        }
                    }

                }
                //Right subtree
                else if (string.Compare(lowTarget, lowData) > 0)
                {
                    cur.gsRight = DeleteNode(cur.gsRight, target);
                    if (BalanceFactor(cur) == 2)
                    {
                        if (BalanceFactor(cur.gsLeft) >= 0)
                        {
                            cur = RotateLL(cur);
                        }
                        else
                        {
                            cur = RotateLR(cur);
                        }
                    }
                }
                //If target is found
                else
                {
                    if (cur.gsRight != null)
                    {
                        parent = cur.gsRight;
                        while (parent.gsLeft != null)
                        {
                            parent = parent.gsLeft;
                        }
                        cur.gsData = parent.gsData;
                        cur.gsRight = DeleteNode(cur.gsRight, parent.gsData);
                        if (BalanceFactor(cur) == 2) //Rebalancing
                        {
                            if (BalanceFactor(cur.gsLeft) >= 0)
                            {
                                cur = RotateLL(cur);
                            }
                            else
                            {
                                cur = RotateLR(cur);
                            }
                        }
                    }
                    else
                    {
                        return cur.gsLeft;
                    }
                }
            }

            return cur;
        }

        private int BalanceFactor(Node cur)
        {
            int l = GetHeight(cur.gsLeft);
            int r = GetHeight(cur.gsRight);
            int bFactor = l - r;
            return bFactor;
        }
        #region "AVL Rotations"
        //Rotations of an AVL tree
        private Node RotateRR(Node parent)
        {
            Node pivot = parent.gsRight;
            parent.gsRight = pivot.gsLeft;
            pivot.gsLeft = parent;
            return pivot;
        }
        private Node RotateLL(Node parent)
        {
            Node pivot = parent.gsLeft;
            parent.gsLeft = pivot.gsRight;
            pivot.gsRight = parent;
            return pivot;
        }
        private Node RotateLR(Node parent)
        {
            Node pivot = parent.gsLeft;
            parent.gsLeft = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent)
        {
            Node pivot = parent.gsRight;
            parent.gsRight = RotateLL(pivot);
            return RotateRR(parent);
        }
        #endregion
        private int Max(int l, int r)
        {
            return l > r ? l : r;
        }

        private int GetHeight(Node cur)
        {
            int height = 0;
            if (cur != null)
            {
                int l = GetHeight(cur.gsLeft);
                int r = GetHeight(cur.gsRight);
                int m = Max(l, r);
                height = m + 1;
            }

            return height;
        }
        //Going through AVL tree recursively and finds for target
        public bool Find(string key)
        {
            if (FindRecursive(key, root) != null)
            {
                if (FindRecursive(key, root).gsData.ToLower() == key.ToLower())
                {
                    return true;
                    //Console.WriteLine("{0} was found!", key);
                }
            }

            return false;
        }

        private Node FindRecursive(string target, Node cur)
        {
            if (cur != null)
            {
                string lowTarget = target.ToLower();
                string lowData = cur.gsData.ToLower();
                if (string.Compare(lowTarget, lowData) < 0)
                {
                    if (lowTarget.Equals(lowData))
                    {
                        return cur;
                    }
                    else
                        return FindRecursive(target, cur.gsLeft);
                }
                else
                {
                    if (lowTarget.Equals(lowData))
                    {
                        return cur;
                    }
                    else
                        return FindRecursive(target, cur.gsRight);
                }
            }
            return null;
        }
        //Displays everything in order
        public string Display(ListBox listBox)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty");
                return "Tree is empty";
            }

            return DisplayInOrder(root, listBox);
        }

        private string DisplayInOrder(Node cur, ListBox listBox)
        {
            string s = "";
            if (cur != null)
            {
                s = DisplayInOrder(cur.gsLeft, listBox);
                listBox.Items.Add(cur.gsData);
                s = DisplayInOrder(cur.gsRight, listBox);
            }
            return s;
        }
    }
}
