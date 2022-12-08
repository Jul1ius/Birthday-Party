using System;
using System.Globalization;

namespace Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());

            double cake = rent * 0.2;
            double drinks = cake - (cake * 0.45);
            double man = rent / 3; 

             Console.WriteLine (rent + cake + drinks + man);
            



        }
    }
}
