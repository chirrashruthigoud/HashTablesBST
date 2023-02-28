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


            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "keep");
            hash.Add("7", "putting");
            hash.Add("8", "themselves");
            hash.Add("9", "deliberately");
            hash.Add("10", "into");
            hash.Add("11", "paranoids");
            hash.Add("12", "avoidable");
            hash.Add("13", "situaions");
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value :" + hash5);
            hash.Remove("2");
            string hash2 = hash.Get("2");

            Console.WriteLine("2th index value : " + hash2);
        }
    }
}
