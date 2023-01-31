using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    public class DemoClass
    {

        public void DictionaryDemo()
        {
            Console.WriteLine("\n**********Dictionary PROGRAM **********\n");

            Dictionary<int, string> objDictionary = new Dictionary<int, string>();
            objDictionary.Add(1, "karan");
            objDictionary.Add(2, "chetan");
            objDictionary.Add(3, "yogesh");
            objDictionary.Add(4, "sagar");
            objDictionary.Add(5, "raaj");



            Console.WriteLine("\nAccess value using key(key=1): " + objDictionary[1]);

            Console.WriteLine("\nIterating Dictionary: ");
            foreach (var element in objDictionary)
            {
                Console.WriteLine($"Key = {element.Key} , Value = {element.Value}");
            }
        }

        public void QueueDemo()
        {
            Console.WriteLine("\n**********Queue Demo**********");

            Queue<int> objQueue = new Queue<int>();
            objQueue.Enqueue(1);
            objQueue.Enqueue(2);
            objQueue.Enqueue(3);
            objQueue.Enqueue(4);
            Console.WriteLine($"\nHead: {objQueue.Peek()}");
            Console.WriteLine($"\nIterating the queue elements: ");

            foreach (var element in objQueue)
            {
                Console.WriteLine(element);
            }
            int objDequeue = objQueue.Dequeue();
            Console.WriteLine($"\nDequeue element: {objDequeue}");

            Console.WriteLine("\nIterating the queue elements after dequeue one element: ");
            Queue<int>.Enumerator ObjEnumerator = objQueue.GetEnumerator();
            while (ObjEnumerator.MoveNext())
            {
                Console.WriteLine(ObjEnumerator.Current);
            }
        }
        public void QueueProblem()
        {
            Console.WriteLine("\n**********Queue Problem **********");

            Queue<int> objQueue = new Queue<int>();
            objQueue.Enqueue(1);
            objQueue.Enqueue(2);
            objQueue.Enqueue(3);
            objQueue.Enqueue(4);
            Console.WriteLine($"\nHead: {objQueue.Peek()}");
            Console.WriteLine($"\nIterating the queue elements: ");

            foreach (var element in objQueue)
            {
                Console.WriteLine(element);
            }
            int objDequeue = objQueue.Dequeue();
            Console.WriteLine($"\nDequeue element: {objDequeue}");

            Console.WriteLine("\nIterating the queue elements after dequeue one element: ");
            Queue<int>.Enumerator ObjEnumerator = objQueue.GetEnumerator();
            while (ObjEnumerator.MoveNext())
            {
                Console.WriteLine(ObjEnumerator.Current);
            }
        }

        public void StackProblem()
        {
            Console.WriteLine("\n**********Stack Demo**********");

            Stack<string> objStack = new Stack<string>();
            objStack.Push("a");
            objStack.Push("b");
            objStack.Push("c");
            objStack.Push("d");
            objStack.Push("e");

            string objPop = objStack.Pop();
            foreach (var element in objStack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine($"\nPoped element: {objPop}");
        }
    }
}

