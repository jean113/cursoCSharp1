using System;

namespace ex4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public override string ToString()
        {
            return (Nome +", R$" + SalarioLiquido());  
        }

        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto +=  (SalarioBruto * porcentagem) / 100;
        }
    }
}