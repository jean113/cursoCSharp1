using System;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() {10,0,2,4,5,6,8};  
            SortedSet<int> b = new SortedSet<int>() {10,5,6,7,8,9};

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(c);
            PrintCollection(d);
            PrintCollection(e);

        }

        static void PrintCollection<T>(IEnumerable<T>  collection)
        {
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
        }

       
    }
    
}
