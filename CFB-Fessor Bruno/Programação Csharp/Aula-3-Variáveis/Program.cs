using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variáveis
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            TIPOS DE VARIÁVEIS
            byte n1 = 10; //0 e 255
            int num = 0; //númerico
            char letra = 'c'; //tipo caractere
            float valor = 5.3f; //ponto flutuante
         */

            //ENTRADA
            string nome = "Eduardo";//conjunto de caracteres
            int num1, num2, res;
            
            //PROCESSAMENTO
            var aux = nome;//não atribuido tipo ou encorporado a outro tipo definido
            num1 = 10;
            num2 = 2;
            res = num1 * num2;


            //SAIDA
            Console.WriteLine("Valor da variável: " + aux + "...\n");
            Console.WriteLine("O valor de num1 é, " + num1 + " O valor de num2 é, " + num2 + " e o resultado da multiplicação entre eles é " + res);
            Console.ReadKey();

        }
    }
}
