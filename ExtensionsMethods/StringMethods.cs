namespace System
{
    static class StringMethods
    {
        public static string Cut(this string objeto, int count)
        {
            if (objeto.Length <= count)
                return objeto;
            else
            {
                return objeto.Substring(0, count) + "...";
            }
        }
    }
}