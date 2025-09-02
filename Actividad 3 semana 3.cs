using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1 = 0;
            double Nota2 = 0;
            double Nota3 = 0;
           
            double Peso1 = 0;
            double Peso2 = 0;
            double Peso3 = 0;
            
            double notaponderada1 = 0;
            double notaponderada2 = 0;
            double notaponderada3 = 0;

            double PromedioFinal = 0;

            Console.Write("Registrar primera nota :");
            string entrada1 = Console.ReadLine(); Nota1 = double.Parse(entrada1);
            
            Console.Write("Registrar segunda nota :");
            string entrada2 = Console.ReadLine(); Nota2 = double.Parse(entrada2);
            
            Console.Write("Registrar tercera nota :");
            string entrada3 = Console.ReadLine(); Nota3 = double.Parse(entrada3);
            
            Console.Write("Registrar su primer peso :");
            string entrada4 = Console.ReadLine(); Peso1 = double.Parse(entrada4);
            
            Console.Write("Registrar su segundo peso :");
            string entrada5 = Console.ReadLine(); Peso2 = double.Parse(entrada5);
            
            Console.Write("Registrar su tercer  peso :");
            string entrada6 = Console.ReadLine(); Peso3 = double.Parse(entrada6);

            notaponderada1 = (Nota1 * (Peso1 / 100));
            notaponderada2 = (Nota2 * (Peso2 / 100));
            notaponderada3 = (Nota3 * (Peso3 / 100));

            PromedioFinal = notaponderada1 + notaponderada2 + notaponderada3;

            Console.WriteLine("Promedio Final :" + PromedioFinal);
            
            
            





        }
    }
}

