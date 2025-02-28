using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Altura: ");
            double H = double.Parse(Console.ReadLine());
            Console.Write("Raio: ");
            double R = double.Parse(Console.ReadLine());
            double V = Math.PI * Math.Pow(R, 2) * H;
           Console.WriteLine($"{V:F3}");
            
        }
    }
}
