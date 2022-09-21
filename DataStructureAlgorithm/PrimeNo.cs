using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class PrimeNo
    {
        public void Primeno()
        {
            int i = 2;
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("To Print Prime Number between 0 to 1000");
            Console.WriteLine("---------------------------\n");
            while (i < 1000)
            {
                bool count = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Console.Write(i + " ");
                }
                i++;
            }
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------\n");
        }
    }
}
