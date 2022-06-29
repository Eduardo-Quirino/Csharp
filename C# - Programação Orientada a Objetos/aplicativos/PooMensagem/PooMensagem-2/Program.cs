using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Mensagem msg1, msg2;

            //Processamento
            msg1 = new Mensagem();
            //msg1.TextoMensagem = "Olá novamente!";
            msg1.ExibirMensagem();

            msg2 = new Mensagem();
            //msg2.TextoMensagem = "No que posso ajudar?";
            msg2.ExibirMensagem();


            //Saida
            Console.ReadKey();
        }
    }
}
