using System;

namespace MethodeSurchargee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                double prix = Convert.ToDouble(Console.ReadLine());
                int remise = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(reducPrice(prix, remise));
            }


        }

        static string ConcatWithSpace(string debut, string fin)
        {
            return debut + " " + fin;
        }

        static double reducPrice(double price, int reduc)
        {
            double remise = price * ((double)reduc/100);
            double finnalyPrice = price - remise;
            return finnalyPrice;
        }
    }
}
