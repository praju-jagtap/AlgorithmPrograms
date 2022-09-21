namespace DataStructureAlgorithm
{
    internal class Program
    {
        const string FILE_PATH = @"C:\GitRepository\AlgorithmPrograms\DataStructureAlgorithm\Words.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Using Binary Search To Find Word From WordList\n2.To Print Prime No Between 0-1000\n3.Bubble Sort Algorithm\n4.Anagram Detection\n5.In Prime No find Palindrome and Anagarm\n");
                Console.WriteLine("Please Enter Your Choice : \n");
                Console.WriteLine("---------------------------\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.Search(FILE_PATH);
                        break;
                    case 2:
                        PrimeNo primeNo = new PrimeNo();
                        primeNo.Primeno();
                        break;
                    case 3:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.bubbleSort(FILE_PATH);
                        break;
                    case 4:
                        Anagarm anagarm = new Anagarm();
                        anagarm.Anagramcheck("heart", "earth");
                        break;
                    case 5:
                        PrimeAnagarm primeAnagarm = new PrimeAnagarm();
                        primeAnagarm.PrimeNumber();
                        primeAnagarm.Palindrome();
                        primeAnagarm.AnagramCheck();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}