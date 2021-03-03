using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize with values
            foreach (KeyValuePair<string, IItem> item in ItemRegistry.Instance.GetAllItems())
            {
                Console.WriteLine($"{item.Key}/{item.Value.GetType()}");
            }

            Console.ReadKey();
        }
    }
}
