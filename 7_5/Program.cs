namespace _7_5
{
    internal class Program
    {
        static void Main()
        {

            Mult(1, 2);
            Mult(2.7, 5.6);

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();

        }
        static int Mult(int a, int b)
        {
            Console.WriteLine($"\nINT\nПроизведение чисел {a} и {b} = {a * b}");
            return a * b; // в одном месте и вывели и вернули =)
        }
        static double Mult(double a, double b)
        {
            Console.WriteLine($"\nDOUBLE\nПроизведение чисел {a} и {b} = {a * b}");
            return a * b; // в одном месте и вывели и вернули =)
        }

    }
}
