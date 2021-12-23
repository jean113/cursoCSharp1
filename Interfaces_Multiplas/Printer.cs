namespace Interfaces_Multiplas
{
    class Printer : Device, IPrint
    {
        public Printer(int serial) : base(serial)
        {
            
        }

        public string Print(string doc)
        {
            return "Printer printing " + doc;
        }
    }
}