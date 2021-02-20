using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ejercicio6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int y = 0, numero;
            Console.WriteLine("Ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (numero + 1); i++)
            {
                if (numero % i == 0)
                {
                    y++;
                }
            }
            if (y != 2)
            {
                Console.WriteLine(numero + " No es primo");
            }
            else
            {
                Console.WriteLine(numero + " Si es primo");
            }
        }

    }
}