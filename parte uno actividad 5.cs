using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string producto;
            string producto1;
                ;
            Console.WriteLine("ingrese la categoria del producto\n-salados\n-dulces\n-bebidas");
            producto = Console.ReadLine(); producto1 = producto.ToUpper();
            if (producto == "SALADOS")
            {
                Console.WriteLine("1. Patatas fritas (bolsa pequeña)     | S/ 4,90     |\r\n| 2. Doritos (bolsa individual)         | S/ 5,30     |\r\n| 3. Galletas saladas (Ritz o similar)  | S/ 4,10     |\r\n| 4. Cacahuetes salados (snack)         | S/ 4,50     |\r\n| 5. Palomitas de maíz (bolsa pequeña)  | S/ 5,30     |\r\n| 6. Mix de frutos secos (25-30g)       | S/ 6,20     |\r\n| 7. Mini pretzels                      | S/ 4,50     |\r\n| 8. Nachos con salsa (pack individual) | S/ 7,40     |\r\n| 9. Bastoncillos de pan con queso      | S/ 4,90     |\r\n| 10. Chips de vegetales  ");
                if () ;
            }
            else if (producto == "DULCES")
            {
                Console.WriteLine("1. KitKat                          | S/ 4,90     |\r\n| 2. M\\&M’s (bolsa pequeña)          | S/ 5,30     |\r\n| 3. Snickers                        | S/ 4,90     |\r\n| 4. Galletas Oreo (mini paquete)    | S/ 4,10     |\r\n| 5. Kinder Bueno                    | S/ 5,30     |\r\n| 6. Chicles (Trident o similar)     | S/ 3,70     |\r\n| 7. Caramelos / Paletas             | S/ 3,30     |\r\n| 8. Twix                            | S/ 4,90     |\r\n| 9. Galletas Chips Ahoy (mini)      | S/ 4,90     |\r\n| 10. Barrita de granola c/chocolate | S/ 5,30     |");
            }
            else if ( producto == "BEBIDAS")
            {
                Console.WriteLine(" 1. Coca-Cola (330 ml)            | S/ 6,20     |\r\n| 2. Agua mineral (500 ml)         | S/ 4,10     |\r\n| 3. Red Bull (250 ml)             | S/ 8,20     |\r\n| 4. Nestea (té helado 500 ml)     | S/ 6,20     |\r\n| 5. Café frío en lata             | S/ 7,40     |\r\n| 6. Aquarius / Gatorade (500 ml)  | S/ 6,60     |\r\n| 7. Fanta / Sprite (330 ml)       | S/ 6,20     |\r\n| 8. Zumo de naranja (200 ml)      | S/ 4,90     |\r\n| 9. Monster Energy (500 ml)       | S/ 9,00     |\r\n| 10. Leche con chocolate (200 ml) | S/ 5,30     |");
            }


        }
    }
}
