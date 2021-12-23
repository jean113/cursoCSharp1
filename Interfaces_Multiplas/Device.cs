namespace Interfaces_Multiplas
{
    abstract class Device
    {
        public int Serial {get; set;}

        public Device(int serial)
        {
            Serial = serial;
        }

        public string ProcessDoc(string doc)
        {
            return "Processing doc " + doc;
        } 
    }
}
