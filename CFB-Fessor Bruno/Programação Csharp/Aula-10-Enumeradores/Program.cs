using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores
{
    internal class Program
    {
        //Entrada
        enum DiasSemana { Domindo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado };
        static void Main(string[] args)
        {
            //Processamento
            DiasSemana ds = (DiasSemana)5;//marcando dia da semana
            //int ds = (int)DiasSemana.Sexta;//converte e imprime em dia numérico

            //Saida
            Console.WriteLine(ds);//imprime dia da semana marcado
            Console.ReadKey();
        }
    }
}
