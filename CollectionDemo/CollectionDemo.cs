using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    internal class CollectionDemo
    {
        public static void DoListDemo()
        {
            Console.WriteLine("\nIn DoListDemo");
            //Creating List
            List<string> list = new List<string>();
            //Adding object to the list
            list.Add("Raja");
            list.Add("Rani");
            list.Add("Ikka");
            list.Add("Joker");
            //Iterating list element
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void DoStackDemo()
        {
            Console.WriteLine("\nIn DoStackDemo");
            //Create the Stack
            Stack<string> stack = new Stack<string>();
            stack.Push("Raja");
            stack.Push("Rani");
            stack.Push("Ikka");
            stack.Push("Joker");
            string pop = stack.Pop();
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Poped Element : " + pop);
        }
        public static void DoSetDemo()
        {
            Console.WriteLine("\nIn DoSetDemo");
            //Create the Hashset
            HashSet<string> set = new HashSet<string>();
            set.Add("Raja");
            set.Add("Rani");
            set.Add("Ikka");
            set.Add("Joker");
            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public static void DoDictionaryDemo()
        {
            Console.WriteLine("\nIn DoDictionaryDemo");
            //Create The Dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Raja");
            dictionary.Add(101, "Rani");
            dictionary.Add(102, "Ikka");
            dictionary.Add(103, "Joker");
            Console.WriteLine("Access Value Using key(key=100) :" + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary");
            foreach (var item in dictionary)
            {
                Console.WriteLine("Key = " + item.Key + "and Value =" + item.Value);
            }
        }
        public static void DoQueueDemo()
        {
            Console.WriteLine("\nIn DoQueueDemo");
            //Create Queue
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Raja");
            queue.Enqueue("Rani");
            queue.Enqueue("Ikka");
            queue.Enqueue("Joker");
            Console.WriteLine("Head : " + queue.Peek());
            Console.WriteLine("\nIterating the Queue Elements");
            // Iterating Queue Elements
            foreach (string element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue Element : " + dequeue);

            Console.WriteLine("\nIterating the Queue Elements after Dequeue one Element");
            // Iterating Queue Elements Using Enumerator 
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        
    }
}
