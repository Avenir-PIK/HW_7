using System.Xml.Linq;

namespace _7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int n = 10;
            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = rnd.Next(1, 100);

            MaxInArray(array[1], array[2], array[3]);
            MaxInArray(array[1], array[2], array[3], array[4], array[5], array[6], array[7]);

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

            static void MaxInArray(params int[] inNumbers)
            {
                int max = inNumbers[0];
                Console.Write($"\nсреди чисел: ");
                foreach (int num in inNumbers)
                {
                    if (num > max) max = num;
                    Console.Write($"{num} ");
                }
                Console.WriteLine($"\nНаибольшее число = {max}");
            }
        }
    }
}
