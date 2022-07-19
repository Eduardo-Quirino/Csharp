﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional_IF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          IF   => SE
          ELSE => SE NÂO  
         */

            //ENTRADA
            int n1, n2, n3, n4, res;//variáveis
            n1 = n2 = n3 = n4 = 0;
            string resultado;

            //PROCESSAMENTO
            Console.WriteLine("Digite valor nota1: ");//pede valor da nota
            n1 = int.Parse(Console.ReadLine());//conversão

            Console.WriteLine("Digite valor nota2: ");//pede valor da nota
            n2 = int.Parse(Console.ReadLine());//conversão

            Console.WriteLine("Digite valor nota3: ");//pede valor da nota
            n3 = int.Parse(Console.ReadLine());//conversão

            Console.WriteLine("Digite valor nota4: ");//pede valor da nota
            n4 = int.Parse(Console.ReadLine());//conversão

            res = n1 + n2 + n3 + n4;

            /*
               >=60 - Aprovado
               59 e 40 - Recuperação 
               <40 - Reprovado
             */
            if ((res < 40))
            {
                resultado = "Reprovado";
            }
            else if (res < 60)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Aprovado";
            }

            //SAIDA
            Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);
            Console.ReadKey();



        }
    }
}
