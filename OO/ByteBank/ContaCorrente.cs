
namespace ByteBank
{
    public class ContaCorrente
    {
        //É possível ter um dos métodos do atributo público como privado.
        public static int TotalDeContasCriadas {get; private set;}
        public int Agencia { get; set;}
        public int Conta {get; set;}
        private double _saldo = 100;

        //Uso de get e set como boa prática. 
        public Cliente Titular {get; set;}
        public double Saldo 
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                    return;
                _saldo = value;
            }
        }

        //Definição de um método construtor. 
        public ContaCorrente(int conta, int agencia)
        {
            Conta = conta;
            Agencia = agencia;
            ContaCorrente.TotalDeContasCriadas++;
        }
        public bool Sacar(double valor)
        {
            if(this._saldo < valor)
                return false;
                    
            this._saldo -= valor;
            return true;
            
        }

        public void Depositor(double vaalor)
        {
            this._saldo += vaalor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if(this._saldo < valor)
                return false;
            
            this._saldo -= valor;
            contaDestino.Depositor(valor);
            return true;
            
        }
    }
}
