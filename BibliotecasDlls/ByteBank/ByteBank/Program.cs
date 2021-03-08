using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2021, 02, 19);
            DateTime dataAtual = DateTime.Now;

            TimeSpan data = dataFimPagamento - dataAtual;
            Console.WriteLine("Diferença é de: " + TimeSpanHumanizeExtensions.Humanize(data))
                ;
        }
    }
}
