using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_v2.Funcionarios
{
    public class Funcionario
    {
        private int _tipo;
        public string nome {get; set;}
        public string CPF { get; set; }
        public double Salario { get; set; }

        public double GetBonificacao()
        {
            if(_tipo == 1)
                return Salario;
            return Salario * 0.10;
        }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }
    }

}