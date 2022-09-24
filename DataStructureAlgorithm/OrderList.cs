using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class OrderList
    {
        public void Link(string file)
        {
            string data = File.ReadAllText(file);
            string[] words = data.Split(" ");
            LinkedListGeneric<string> list = new LinkedListGeneric<string>();
            foreach (var item in words)
            {
                list.Add(item);
            }
            list.Display();
            Console.WriteLine("\nEnter word to search:");
            string search = Console.ReadLine();
            int count = list.Search(search);
            if (count == 0)
            {
                list.Add(search);
            }
            else
            {
                Console.WriteLine(words[count]);
            }
            File.WriteAllText(file, list.ToString());
        }
    }
}
