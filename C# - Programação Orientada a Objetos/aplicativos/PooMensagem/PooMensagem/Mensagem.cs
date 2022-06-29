using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{//< public > deixando objeto publico para ser usado em outra instância
    public class Mensagem
    {

       public String TextoMensagem;
        
       public void ExibirMensagem()//método exibir mensagem
        {
            Console.WriteLine(this.TextoMensagem);//this enterage com objeto
        }

    }
}
