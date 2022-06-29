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
            msg1 = new Mensagem();//objeto1
            msg1.TextoMensagem = "Olá, seja bem vindo!\n";//instância
            msg1.ExibirMensagem();//ação do objeto1

            msg2 = new Mensagem();//objeto2
            msg2.TextoMensagem = "Segundo objeto";//instância
            msg2.ExibirMensagem();//ação do objeto2

            //SAIDA
            Console.ReadKey();
        }
    }
}
