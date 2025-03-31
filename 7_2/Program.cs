using System.Xml.Linq;

namespace _7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int n = 10;
            int[] array = new int[n];
            for (int i = 0; i < n; i++) array[i] = rnd.Next(1,10);

            PrintArray(array);
            PrintArray(array, true);

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();

            static void PrintArray(int[] arr, bool rev = false)
            {
                if (!rev)
                {
                    Console.WriteLine("\n\nДополнительный агрумент = false (default), выводим неизменный массив:");
                    foreach (int element in arr)
                        Console.Write($"{element} ");

                }
                else
                {
                    Console.WriteLine("\n\nДополнительный агрумент = true, выводим отзеркаленный массив:");
                    for (int i = arr.Length-1; i >= 0; i--)
                    {
                        Console.Write($"{arr[i]} ");
                    }
                }
            }
        }
    }
}
