using System.Security.Cryptography;

namespace _7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, b1, c1, a2, b2, c2;
            Random rnd = new Random();

            // создаём первый треугольник
            do
            {
                a1 = rnd.Next(5, 15);
                b1 = rnd.Next(5, 15);
                c1 = rnd.Next(5, 15);
            }
            while (a1 > b1 + c1 && b1 > a1 + c1 && c1 > b1 + a1); //каждая сторона должна быть меньше суммы двух других


            // создаём первый треугольник
            do
            {
                a2 = rnd.Next(5, 15);
                b2 = rnd.Next(5, 15);
                c2 = rnd.Next(5, 15);
            }
            while (a2 > b2 + c2 && b2 > a2 + c2 && c2 > b2 + a2); //каждая сторона должна быть меньше суммы двух других


            double s1 = Striangle(a1, b1, c1);
            double s2 = Striangle(a2, b2, c2);

            Console.WriteLine($"Первый треугольник со сторонами {a1},{b1},{c1}, имеет площадь {s1}");
            Console.WriteLine($"Второй треугольник со сторонами {a2},{b2},{c2}, имеет площадь {s2}");

            string result = string.Empty;
            if (s1 == s2) result = "Треугольники равны по площади!";
            if (s1 > s2) result = "Площадь Первого треугольника больше!";
            if (s1 < s2) result = "Площадь Второго треугольника больше!";

            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
            static double Striangle(int a, int b, int c)
            {
                double p = (a + b + c) / 2.0;
                return Math.Pow(p * (p - a) * (p - b) * (p - c), 0.5);
            }
        
    }
}
