using ByteBank_v2.Funcionarios;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_v2
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}