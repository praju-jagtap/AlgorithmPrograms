namespace DataStructureAlgorithm
{
    internal class Program
    {
        const string FILE_PATH = @"C:\GitRepository\AlgorithmPrograms\DataStructureAlgorithm\Words.txt";
        const string EXPRESSION_FILE_PATH = @"C:\GitRepository\AlgorithmPrograms\DataStructureAlgorithm\Expression.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Using Binary Search To Find Word From WordList\n2.To Print Prime No Between 0-1000\n3.Bubble Sort Algorithm\n4.Anagram Detection\n5.In Prime No find Palindrome and Anagarm\n6.Replace Messaage Using String Replace Function\n7.Order List Using LinkedList Generic\n8.Sample Balance Parantheses\n");
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
                    case 6:
                        StringReplace stringReplace = new StringReplace();
                        stringReplace.Validate("\nHello << name >>, We have your fullname as << full name >> in our system.", "abc");
                        stringReplace.ValidateNumber("your contact number is << contactno >>.", "91 8349222345");
                        stringReplace.ValidateDate("Thank you BridgeLabz << Date >>.\n", "24/10/2022");
                        break;
                    case 7:
                        OrderList orderList = new OrderList();
                        orderList.Link(FILE_PATH);
                        break;
                    case 8:
                        BalanceParantheses balanceParentheses = new BalanceParantheses();
                        balanceParentheses.SampleBalance(EXPRESSION_FILE_PATH);
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}