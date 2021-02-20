using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Letra;
            Console.WriteLine("Ingrese una letra (y,Y)");
            Letra = Console.ReadLine();
            if (Letra == "Y")
            {
                Console.Write("Esta Letra Es mayuscula");
            }
            else
            {
                Console.Write("Esta Letra Es minuscula");
            }
        }
    }
}
