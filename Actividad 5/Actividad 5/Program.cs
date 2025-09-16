using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            string linea;
            int producto;
            

            Console.WriteLine("¿Que producto desea tomar? "); linea = Console.ReadLine();
            producto = int.Parse(linea);
            switch (producto) {
                case 1:
                    Console.WriteLine("Ha seleccionado Kitkat\nEl precio del producto es: " + precio1);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else 
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                        break;
                case 2:
                            Console.WriteLine("Ha seleccionado MandMs\nEl precio del producto es: " + precio2);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 3:
                            Console.WriteLine("Ha seleccioando Oreos\nEl precio del producto es: " + precio3);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 4:
                            Console.WriteLine("Ha seleccionado Kinder\nEl precio del producto es: " + precio4);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 5:
                            Console.WriteLine("Ha seleccionado Chicles\nEl precio del producto es: " + precio5);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 6:
                            Console.WriteLine("Ha seleccionado Caramlos\nEl precio del producto es: " + precio6);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 7:
                            Console.WriteLine("Ha seleccionado Twix\nEl precio del producto es: " + precio7);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 8:
                            Console.WriteLine("Ha seleccionado Galletas\nEl precio del producto es: " + precio8);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 9:
                            Console.WriteLine("Ha seleccionado Barrita\nEl precio del producto es: " + precio9);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        case 10:
                            Console.WriteLine("Ha seleccionado Snickers\nEl precio del producto es: " + precio10);
                    Console.ReadKey();
                    Console.WriteLine("¿Desea continuar? s/n"); linea = Console.ReadLine();
                    if (linea == "n")
                    {
                        Console.WriteLine("Cancelando compra...");
                    }
                    else if (linea == "s")
                    {
                        Console.WriteLine("Realizando compra... \n¡Gracias por comprar!"); Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Comando invalido:(");
                    }
                    break;
                        default:
                            Console.WriteLine("El producto no existe");
                            Console.ReadKey();
                            break;
                        }





















            }
    }
}
