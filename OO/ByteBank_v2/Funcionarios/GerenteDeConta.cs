using ByteBank_v2.Sistemas;
using System;

namespace ByteBank_v2.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {
        //Construtor
        public GerenteDeConta (string cpf) : base(3000, cpf)
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