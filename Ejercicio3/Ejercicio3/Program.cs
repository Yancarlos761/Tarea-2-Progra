using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ejercicio3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a, result, result1, result2;
            Console.WriteLine("Ingresar horas trabajadas");
            a = int.Parse(Console.ReadLine());
            if (a <= 40)
            {
                result = a * 16;
                Console.Write("Total de sueldo" + result);
            }
            else
            {
                result = a - 40;
                result1 = result * 20;
                result2 = result1 + 640;
                Console.Write("sueldo:" + result2);
            }
        }
    }
}
