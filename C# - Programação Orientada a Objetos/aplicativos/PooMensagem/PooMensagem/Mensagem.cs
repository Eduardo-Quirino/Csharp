﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooMensagem
{
    public class Mensagem
    {

       public String TextoMensagem;

       public void ExibirMensagem()
        {
            Console.WriteLine(this.TextoMensagem);
        }

    }
}
