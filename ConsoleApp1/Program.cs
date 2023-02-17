using System;

namespace Vault
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a;
            decimal b;
            decimal c;
            decimal d;
            decimal e;
            decimal f;
            a= 1;
            b= 2;
            c= 3;
            d= 4;
            e= 5;
            f= 6;
            decimal rezalt = (a - b) / c / d * e / f;
            Console.WriteLine(rezalt);
        }
    }
}