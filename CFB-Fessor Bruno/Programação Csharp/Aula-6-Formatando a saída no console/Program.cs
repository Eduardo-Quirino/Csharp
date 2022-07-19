using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatando_a_saída_no_console
{
    internal class Program
    {
        static void Main(string[] args)
        {//saída no console

            //ENTRADA
            double valorCompra = 8.50;
            double valorVenda;
            double lucro = 0.20;
            string produto = "Pastel";

            //PROCESSAMENTO
            valorVenda = valorCompra + (valorCompra * lucro);

            //SAIDA
            Console.WriteLine("Produto...........:{0,15}", produto);
            Console.WriteLine("Valor Compra......:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro.............:{0,15:p}", lucro);
            Console.WriteLine("Valor Venda.......:{0,15:c}", valorVenda);
            Console.ReadKey();

        }
    }
}
