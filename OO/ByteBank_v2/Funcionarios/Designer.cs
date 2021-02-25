using System;

namespace ByteBank_v2.Funcionarios
{
    public class Designer : Funcionario
    {
        //Construtor
        public Designer(string cpf) : base(1500, cpf)
        {

        }
        public override double GetBonificacao()
        {
            return Salario;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}