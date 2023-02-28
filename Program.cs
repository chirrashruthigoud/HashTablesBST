using HashTablesBST;

namespace HashBinary
{
    public class Program
    {
        public static void Main(string[] args)
        {
        
                Console.WriteLine(" Hash and Binary Table Program  ");
                BinaryTree b1 = new BinaryTree();
                b1.Add(56);
                b1.Add(30);
                b1.Add(70);

                b1.TraversePreorder(b1.root);


            }
        }
}
