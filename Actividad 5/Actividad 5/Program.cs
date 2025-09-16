using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio1 = 6.20, precio2 = 4.10, precio3 = 8.20;
            double precio4 = 6.20, precio5 = 7.40, precio6 = 6.60;
            double precio7 = 6.20, precio8 = 4.90, precio9 = 9.00, precio10 = 5.30;

            int opcion;
            string entrada;

            Console.WriteLine("Elija la bebida:");
            Console.WriteLine("1. CocaCola (330 ml)");
            Console.WriteLine("2. Agua Mineral (500 ml)");
            Console.WriteLine("3. Red Bull (250 ml)");
            Console.WriteLine("4. Nestea (té helado 500 ml)");
            Console.WriteLine("5. Café frío en lata");
            Console.WriteLine("6. Aquarius/Gatorade (500 ml)");
            Console.WriteLine("7. Fanta/Sprite (330 ml)");
            Console.WriteLine("8. Zumo de naranja (200 ml)");
            Console.WriteLine("9. Monster Energy (500 ml)");
            Console.WriteLine("10. Leche con chocolate (200 ml)");
            Console.Write("\nIngrese el número de su elección: ");
            entrada = Console.ReadLine();
            opcion = int.Parse(entrada);
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ha seleccionado CocaCola (330 ml)\nEl precio es: " + precio1);
                    break;
                case 2:
                    Console.WriteLine("Ha seleccionado Agua Mineral (500 ml)\nEl precio es: " + precio2);
                    break;
                case 3:
                    Console.WriteLine("Ha seleccionado Red Bull (250 ml)\nEl precio es: " + precio3);
                    break;
                case 4:
                    Console.WriteLine("Ha seleccionado Nestea (té helado 500 ml)\nEl precio es: " + precio4);
                    break;
                case 5:
                    Console.WriteLine("Ha seleccionado Café frío en lata\nEl precio es: " + precio5);
                    break;
                case 6:
                    Console.WriteLine("Ha seleccionado Aquarius/Gatorade (500 ml)\nEl precio es: " + precio6);
                    break;
                case 7:
                    Console.WriteLine("Ha seleccionado Fanta/Sprite (330 ml)\nEl precio es: " + precio7);
                    break;
                case 8:
                    Console.WriteLine("Ha seleccionado Zumo de naranja (200 ml)\nEl precio es: " + precio8);
                    break;
                case 9:
                    Console.WriteLine("Ha seleccionado Monster Energy (500 ml)\nEl precio es: " + precio9);
                    break;
                case 10:
                    Console.WriteLine("Ha seleccionado Leche con chocolate (200 ml)\nEl precio es: " + precio10);
                    break;
                default:
                    Console.WriteLine("Bebida no encontrada,");
                    break;
            }

        }
    }
}