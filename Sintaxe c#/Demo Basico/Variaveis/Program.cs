using System;

namespace Variaveis
{
    internal class Program
    {
        public static bool Boolean { get; private set; }

        static void Main(string[] args)
        {
            //Como declarar Variáveis
            string minhaString;
            minhaString = "Minha string no C#";

            Console.WriteLine(minhaString);
            Console.ReadKey();


            //int -> inteiros
            int v1 = 1;
            int v2, v3 = 3, v4;

            Console.WriteLine("Valor da v3: " + v3);

            //var
            var num1 = 1;

            //Boleano
            bool verdadeiro = true;
            Boolean = false;
            var flag = false;

            //Byte
            byte bMin = Byte.MinValue;
            byte bMax = Byte.MaxValue;
            Console.WriteLine("Valor do bMin" + bMin);
            Console.WriteLine("Valor do bMax" + bMax);


            Console.WriteLine("*** Fim do programa ***");
            Console.ReadKey();
             
            
          
        }
    }
}
