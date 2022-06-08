using System;

namespace Eje1sel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("De un numero: ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
                Console.WriteLine("Es negativo...");
            else
                if (num < 0)
                Console.WriteLine("Es negativo...");
            else
                Console.WriteLine("Es cero  ...");

            Console.ReadKey();
        }
    }
}
