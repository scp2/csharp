using System;
using ByteBank_v2.Funcionarios;

namespace ByteBank_v2.Sistemas
{
    public class SistemaInterno
    {
        public bool logar(Diretor funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
        
    }
}