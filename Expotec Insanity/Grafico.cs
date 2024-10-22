using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expotec_Insanity
{
    internal class Grafico
    {
        public static string EscreverLinha(char Caracter)
        {
            int Tamanho = 5;
            string linha = "";
            for (int i = 0; i <= Tamanho; i++)
            {
                linha += Caracter;
            }
            linha += "\n";
            return linha;
        }
    }
}
