namespace ex5
{
    class Conta
    {
        //auto propriedade
        public string Numero {get; set;}
        private string _titular;
        public double Saldo {get; set;}

        //propriedade
        public string Titular
        {
            get {return _titular;}
            set 
            {
                if(value != null  && value.Length > 1)
                    _titular = value;
            }
        }

        public Conta()
        {
            Saldo = 0;
        }

        public void Deposito(double dinheiro)
        {
           Saldo += dinheiro;
        }

        public void Saque(double dinheiro)
        {
            if(Saldo >= 0)
               Saldo -= (dinheiro + 5);
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: " + Saldo ;
        }

        

    }
}