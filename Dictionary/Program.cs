using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydictionary<int, string> name = new Mydictionary<int, string>();
            name.Add(13213, "firat");
            Console.WriteLine(name.Count);
            name.Print();
            
            
        }
    }
}
