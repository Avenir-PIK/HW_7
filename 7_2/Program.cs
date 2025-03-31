namespace _7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vol, sqr;
            int a;
            Console.WriteLine("Введите длину стороны куба");
            a = Convert.ToInt32(Console.ReadLine());

            CubeCalc(a, out vol, out sqr);

            Console.WriteLine($"Объём куба со стороной {a} = {vol}");
            Console.WriteLine($"Площадь поверхности куба со стороной {a} = {sqr}");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
        static void CubeCalc(int a, out double vol, out double sqr)
        {
            vol = Math.Pow(Convert.ToDouble(a), 3);
            sqr = Math.Pow(Convert.ToDouble(a), 2) * 6;
        }

    }
}