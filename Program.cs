using HashTablesBST;

namespace HashBinary
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BinaryTree b1 = new BinaryTree();
            b1.Add(56);
            b1.Add(30);
            b1.Add(70);
            b1.Add(60);
            b1.Add(95);
            b1.Add(65);
            b1.Add(63);
            b1.Add(67);
            b1.Add(22);
            b1.Add(40);
            b1.Add(11);
            b1.Add(3);
            b1.Add(16);

            b1.TraversePreorder(b1.root);

        }
    }
}
