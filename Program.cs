using HashTablesBST;

namespace HashBinary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" Hash and Binary Table Program  ");
            Console.WriteLine("Hash table demo");

            MyMapNode<string, string> hash = new MyMapNode<string, string>[5];
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

        }
    }
}
