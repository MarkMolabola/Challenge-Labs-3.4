using System.Diagnostics.Metrics;
using System.Text;

namespace Challenge_Labs_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder jumboLetters = new StringBuilder("ABCBABDACDBAB");
            int length = jumboLetters.Length;
            Console.WriteLine("The original string is: " + jumboLetters);
            bool flag = true;
            int counter = 0;
            do
            {
                for (int i = 0; i < jumboLetters.Length - 1; i++)
                {
                    if ((jumboLetters[i] == 'A' && jumboLetters[i + 1] == 'B') || (jumboLetters[i] == 'C' && jumboLetters[i + 1] == 'B'))
                    {

                        Console.WriteLine($"{jumboLetters[i]} and {jumboLetters[i + 1]} has been removed");
                        jumboLetters.Remove(i, 2);
                        Console.WriteLine($"The new string is: {jumboLetters}");
                        break;
                    }
                }
                counter++;
                if (counter == length/2)
                {
                    flag = false;
                }
            }
            while (flag);
            
            Console.WriteLine("The final string is: " + jumboLetters);
            Console.WriteLine("The length of the final string is: " + jumboLetters.Length);
        }
    }
}
