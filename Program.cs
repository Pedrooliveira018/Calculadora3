using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calculadora

         decimal numero_um;
         decimal numero_dois;

            //Solicitar valores
            Console.WriteLine("Bem vindo");
         Console.WriteLine("Digite o primeiro numero:");
         numero_um = decimal.Parse(Console.ReadLine());

         Console.WriteLine("Fale outro numero:");
         numero_dois = decimal.Parse(Console.ReadLine());

            //Calcular valores

        decimal soma = numero_um + numero_dois;
        decimal sub = numero_um - numero_dois;
        decimal mutl = numero_um * numero_dois;
        decimal div = numero_um / numero_dois;

            //Resultados

            Console.WriteLine("A soma dos valores é:" + soma);
            Console.WriteLine("A sub dos valores é:" + sub);
            Console.WriteLine("A mult dos valores é:" + mutl);
            Console.WriteLine("A divisao dos valores é:" + div);
        }   
    }
}
