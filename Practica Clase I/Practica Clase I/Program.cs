using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Clase_I
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            //Conversiones
            Console.WriteLine("Hola Mundo");
            int n = 10;
            double x = (double)n;
            //
            string a = "10";
            int num = Convert.ToInt32(a);
            //
            string aa = "20";
            int kk = int.Parse(aa);
            //
            int nn = 1000;
            string abc = nn.ToString();
            //
            Console.WriteLine(kk);
         */
            int valor1, valor2;
            int resultado;
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Introduce valor 1: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce valor 2: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            resultado = valor1 + valor2;
            //Console.WriteLine("El resultado de {0} + {1} es {2}",valor1,valor2,resultado);
            Console.WriteLine($"El resultado de {valor1} + {valor2} es {resultado}");

            Console.ReadKey();


        }
    }
}
