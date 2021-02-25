using System;

namespace ByteBank_v2.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        //Construtor
        public Auxiliar(string cpf) : base(1500, cpf)
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