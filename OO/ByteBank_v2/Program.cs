using System;
using ByteBank_v2.Funcionarios;
using ByteBank_v2.Sistemas;

namespace ByteBank_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Desenvolvedor carlos = new Desenvolvedor("546.879.157-20");
            carlos.Nome = "Carlos";

            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
    
            gerenciador.Registrar(carlos);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
            Console.ReadLine();
        }
        public static void UsaeSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("454.658.148-3");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "321");

        }
    }
}
