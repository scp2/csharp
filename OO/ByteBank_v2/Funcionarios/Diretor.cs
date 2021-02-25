using ByteBank_v2.Sistemas;
using System;

namespace ByteBank_v2.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public bool Autenticar(string senha)
        {
            if(this.Senha == senha)
                return true;
            
            return false;
        }
    }
}