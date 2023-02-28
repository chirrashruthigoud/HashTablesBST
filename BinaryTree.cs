using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HashTablesBST
{
    public class BinaryTree
    {
        public Node root { get; set; }

        public bool Add(int value)
        {
            Node before = null;
            Node after = this.root;

            if (after != null)
            {
                before = after;
                if (value < after.data)
                {
                    after = after.LeftNode;
                }
                else if (value > after.data)
                {
                    after = after.RightNode;
                }
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.data = value;
            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                if (value < before.data)
                {
                    before.LeftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;
                }

            }
            return true;
        }

        public void TraversePreorder(Node Parent)
        {
            if (Parent != null)
            {
                Console.WriteLine(Parent.data + " ");
                TraversePreorder(Parent.LeftNode);
                TraversePreorder(Parent.RightNode);
            }
        }
    }
}
