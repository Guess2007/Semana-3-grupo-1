using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Actividad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio1 = 4.90, precio2 = 5.30, precio3 = 4.90;
            double precio4 = 4.10, precio5 = 5.30, precio6 = 3.70;
            double precio7 = 3.30, precio8 = 4.90, precio9 = 4.90, precio10 = 5.30;
            byte kitkat, MandMs, Snickers, Oreos, Kinder, Chicles, Caramelos, Twix, Galletas, Barrita;
            string linea;
            string producto;
            byte Articulo;

            Console.WriteLine("¿Que producto desea tomar: "); linea = Console.ReadLine();
            Articulo = byte.Parse(linea);


            switch (producto) {
                case 1:
                    Console.WriteLine("Ha seleccionado Kitkat" "\nEl precio del producto es: " + precio1);
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado MandMs" "\nEl precio del producto es: " + precio2);
                    break;
                case 3:
                    Console.WriteLine("Ha seleccioando Oreos" "\nEl precio del producto es: " + precio3);
                    break;
                case 4:
                    Console.WriteLine("Ha seleccionado Kinder" "\nEl precio del producto es: " + precio4);
                    break;
                case 5:
                    Console.WriteLine("Ha seleccionado Chicles" "\nEl precio del producto es: " + precio5);
                    break;
                case 6:
                    Console.WriteLine("Ha seleccionado Caramlos" "\nEl precio del producto es: " + precio6);
                    break;
                case 7:
                    Console.WriteLine("Ha seleccionado Twix" "\nEl precio del producto es: " + precio7);
                    break;
                case 8:
                    Console.WriteLine("Ha seleccionado Galletas" "\nEl precio del producto es: " + precio8);




















        }
    }
}
