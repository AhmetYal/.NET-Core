using System;

namespace _NET_Core
{
    class Program
    {
        private const string V = "merhaba";

        public  static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             Console.WriteLine("İsmini gir");
            string name=Console.ReadLine();
            Console.WriteLine("Soyisim");
            string surname=Console.ReadLine();
Console.WriteLine(V + name+""+surname);
        }
    }
}
