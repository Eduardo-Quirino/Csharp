using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_e_Operações
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //atribuição
            int res = (10 + 5) * 2;//mais

            Console.WriteLine("atribuição " + res);
            Console.ReadKey();


            //relacionais comparação
            bool res2 = 10 < 5;//menor que

            Console.WriteLine("\n relacionais comparação " + res2);
            Console.ReadKey();

            bool re3 = 10 != 5;//diferente 
            Console.WriteLine("\n relacionais comparação " + re3);
            Console.ReadKey();


            //incremento decremento
            int num = 10;

            num++;//num += 1;num = num = 1;

            Console.WriteLine("\n incremento decremento " + num);
            Console.ReadKey();


            /*outro exenplo incremento decremento
             pode ser usado em ( + - / * )
            */
            int num2 = 10;

            num2 += 10;//num = num2 + 2;

            Console.WriteLine("\n outro exenplo incremento decremento " + num2);
            Console.ReadKey();


            //operadores lógicos
            /*
             & = AND / E
             | = OR / OU
             */
            bool res3 = (5 > 3) | (10<5);//True
            bool res4 = (5 > 3) & (10 < 5);//False


            Console.WriteLine("\n operadores lógicos |" + res3);
            Console.WriteLine("\n operadores lógicos & " + res4);
            Console.ReadKey();
        }
    }
}
