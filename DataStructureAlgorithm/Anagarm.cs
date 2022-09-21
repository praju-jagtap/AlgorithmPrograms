using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithm
{
    internal class Anagarm
    {
        public void Anagramcheck(string firstInput, string lastInput)
        {
            char[] firstArr = firstInput.ToCharArray();
            Array.Sort(firstArr);
            char[] lastArr = lastInput.ToCharArray();
            Array.Sort(lastArr);
            if (firstArr.Length.Equals(lastArr.Length))
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (!firstArr[i].Equals(lastArr[i]))
                    {
                        Console.WriteLine("---------------------------\n");
                        Console.WriteLine("Not An Anagram");
                        Console.WriteLine("---------------------------\n");
                        return;
                    }
                }
                Console.WriteLine("---------------------------\n");
                Console.WriteLine("Anagram");
                Console.WriteLine("---------------------------\n");
            }
            else
            {
                Console.WriteLine("---------------------------\n");
                Console.WriteLine("Not An Anagram");
                Console.WriteLine("---------------------------\n");
            }
        }
    }
}
