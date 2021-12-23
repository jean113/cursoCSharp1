using System;

namespace ex3
{
    class Aluno
    {
        public double N1, N2, N3, NF;
        public string Nome;

        public void resultado()
        {
            NF = N1 + N2 + N3;

            Console.WriteLine("Nota Final: " + NF);

            if(NF >= 60)
            {
                Console.WriteLine("APROVADO");   
            }
            else
            {
                Console.WriteLine("REPROVADO"); 
                Console.WriteLine("FALTARAM " + (60 - NF ) + " PONTOS." );
            }
        }  
    }
}