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
    }
}

