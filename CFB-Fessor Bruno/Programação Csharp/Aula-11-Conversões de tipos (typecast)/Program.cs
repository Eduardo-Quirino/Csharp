using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversões_de_tipos__typecast_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENTRADA
            float n1 = 10.5f;

            //PROCESSAMENTO
            int n2 = (int)n1;//operação de type cast

            //SAIDA
            Console.WriteLine(n2);
            Console.ReadKey();
        }
    }
}
