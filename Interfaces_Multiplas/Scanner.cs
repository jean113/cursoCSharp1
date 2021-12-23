namespace Interfaces_Multiplas
{
    class Scanner : Device, IScan
    {
        public Scanner(int serial) : base(serial)
        {
            
        }

        public string Scan()
        {
            return "Scanner scanning result";
        }
    }
}