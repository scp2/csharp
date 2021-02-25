using System;

namespace ByteBank_v2.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        //Construtor
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.12;
        }
    }
}