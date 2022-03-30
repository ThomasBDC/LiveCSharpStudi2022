using System;
using MaPremiereLibrairie;

namespace PremiereApplicationConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Class1.DisBonjour("Julien");

            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
