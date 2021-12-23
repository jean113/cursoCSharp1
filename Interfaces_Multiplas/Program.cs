using System;

namespace Interfaces_Multiplas
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer(123);
            Console.WriteLine(p.ProcessDoc("My Letter"));
            Console.WriteLine(p.Print("My Letter"));

            Scanner s = new Scanner(321);
            Console.WriteLine(s.ProcessDoc("My Magazine"));
            Console.WriteLine(s.Scan());

            Multifunctional m = new Multifunctional(456);
            Console.WriteLine(m.ProcessDoc("My dissertation"));
            Console.WriteLine(m.Print("My dissertation"));
            Console.WriteLine(m.ProcessDoc("My Magazine"));
            Console.WriteLine(m.Scan());


        }
    }
}
