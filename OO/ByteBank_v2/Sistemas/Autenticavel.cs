using ByteBank_v2.Funcionarios;
using System;

namespace ByteBank_v2.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public Autenticavel(double salario, string cpf) : base(salario, cpf)
        {
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}