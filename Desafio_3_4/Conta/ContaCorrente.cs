namespace Desafio_3.Conta
{
  class ContaCorrente : Conta, Imposto
    {
      public ContaCorrente(string numero, string titular, double saldo) : base(numero, titular, saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        private double _imp;


        public override double RendimentoContas()
        {
            Saldo += Saldo * 0.03;
            return Saldo;
        }

        public double CalculoImposto()
        {
            _imp = RendimentoContas() * 0.25;
            return _imp;
        }

        public override string ToString()
        {
            return
              $"Conta: {Numero} - Titular: {Titular} - Saldo inicial: {Saldo} - Rendimento: {RendimentoContas()} - Impostos: {CalculoImposto()}";
        }

        

    }
}
