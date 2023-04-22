using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            double n;  
            double z;
            double A;
            double pi = 3.14;
            double D;
            double y;

            Console.WriteLine("valor de D");
            D = double.Parse(Console.ReadLine());

            r = 2 * D;
            z = r;
            Console.WriteLine("valor do diametro {0}", r);

            y = r * z;
            n = y / 4;
            A = pi * n;
            Console.WriteLine("valor da area {0}", A);
            
        }
    }
}
