namespace Desafio_3.Conta
{
 class ContaPoupanca : Conta, Imposto
    {
        public ContaPoupanca(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        private double _imp;
       
       public override double RendimentoContas()
        {
            Saldo += Saldo * 0.05;
            return Saldo;
        }

        public double CalculoImposto()
        {
            _imp += RendimentoContas() * 0.10;
            return _imp;

        }

        public override string ToString()
        {
            return
              $"Conta: {Numero} - Titular: {Titular} - Saldo inicial: {Saldo} - Rendimento: {RendimentoContas()} - Impostos: {CalculoImposto()}";
                
        }        
    }
}
