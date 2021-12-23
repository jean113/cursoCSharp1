namespace Interfaces_Multiplas
{
    class Multifunctional : Device, IPrint,  IScan
    {
        public Multifunctional(int serial) : base(serial)
        {
            
        }

        public string Print(string doc)
        {
            return "Multifunctional printing " + doc;
        }

        public string Scan()
        {
            return "Multifunctional scaning result";
        }
    }
}