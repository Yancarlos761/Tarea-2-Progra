using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cliente
    {
        private float rebaja;
        private float precio;
        public void Inicio()
        {
            Console.WriteLine("INGRESE LA CANTIDAD A PAGAR: ");
            precio = float.Parse(Console.ReadLine());

        }
        public void Descuento()
        {
            if (precio > 300)
            {
                float res = (precio * 20) / 100;
                rebaja = precio - res;
                Console.WriteLine(" METRO PLAZA JUTIAPA");
                Console.WriteLine("DESCUENTO DEL 20%");
                Console.WriteLine("PRECIO ES: " + rebaja);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("METRO PLAZA JUTIAPA");

                Console.WriteLine("PRECIO ES: " + precio);
                Console.ReadLine();

            }
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.WriteLine("METRO PLAZA JUTIAPA");
            Cliente clie = new Cliente();
            clie.Inicio();
            clie.Descuento();

        }

    }
}

