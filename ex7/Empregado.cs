namespace ex7
{
    class Empregado
    {
        public int Id {get; set;}
        public string Nome{get; set;}
        public double Salario{get; set;}
          
        public void IncrementarSalario(double porc)
        {
            Salario += (Salario * porc) / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Nome + ", "  +  Salario;
        }
    }
}