using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem_2
{
    internal class Mensagem
    {

        private String TextoMensagem;

        public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

        public String getTextoMensagem()
        {
            return this.TextoMensagem;
        }

    }
}
