using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENTRADAS
            Mensagem msg1, msg2;

            //PROCESSAMENTO
            msg1 = new Mensagem();
            msg1.TextoMensagem = "Olá, seja bem vindo!";
            msg1.ExibirMensagem();

            msg2 = new Mensagem();
            msg2.TextoMensagem = "Segundo objeto";
            msg2.ExibirMensagem();

            //SAIDA
            Console.ReadKey();
        }
    }
}
