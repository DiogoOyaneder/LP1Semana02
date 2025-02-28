using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insere número inteiro-não negativo: ");
            byte b1 = byte.Parse(Console.ReadLine());
            byte b2 = b1;
            byte b3 = b1;
    

            Console.WriteLine(b1/2);
            b2 = (byte)(b2 << 3);
            Console.WriteLine(b2);
            b3 = (byte)(b3 ^ 6);
            Console.WriteLine(b3);
            bool b4 = (b1 > 10);
            Console.WriteLine(b4);
        }
    }
}
