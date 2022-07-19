using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lendo_valores_do_teclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            int val1, val2, soma;

            //PROCESSAMENTO
            Console.Write("Digite o primeiro valor: ");
            val1 = int.Parse(Console.ReadLine());//primeiro modo de conversão

            Console.Write("Digite o segundo valor: ");
            val2 = Convert.ToInt32(Console.ReadLine());//segundo modo de conversão

            soma = val1 + val2;
            Console.WriteLine("A soma de {0} mais {1} é igual a {2}", val1, val2, soma);

            //SAIDA
            Console.ReadKey();
        }

    }
}
