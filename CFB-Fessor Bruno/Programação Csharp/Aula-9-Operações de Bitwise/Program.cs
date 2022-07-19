using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_de_Bitwise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Valpor de operações de Bitwise
                    >>Dobra
                    << Metade   
            */

            //ENTRADA 
            int num = 10;

            //PROCESSAMENTO
            num = num >> 1;

            //SAIDA
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}
