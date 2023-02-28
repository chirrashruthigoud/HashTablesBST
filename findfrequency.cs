using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTablesBST
{
    public class MyMapNode<k, v>
    {
        private readonly int size;
        private readonly LinkedList<KeyValuePair<k, v>>[] items;


        public struct KeyValuePair<k, v>
        {
            public k key { get; set; }
            public v value { get; set; }
        }
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValuePair<k, v>>[size];
        }

        protected int GetArrayPosition(k key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public v Get(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<k, v>> linkedList = GetLinkedList(position);
            foreach (KeyValuePair<k, v> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(v);

        }
        public void Add(k key, v value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<k, v>> linkedList = GetLinkedList(position);
            KeyValuePair<k, v> item = new KeyValuePair<k, v>() { key = key, value = value };
            linkedList.AddLast(item);
        }

        public void Remove(k key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValuePair<k, v>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValuePair<k, v> foundItem = default(KeyValuePair<k, v>);
            foreach (KeyValuePair<k, v> item in linkedList)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }
    }
}
