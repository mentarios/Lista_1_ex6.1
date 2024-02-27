using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex6._1
{
    internal class Program
    {
        // oi
        static void Main(string[] args)
        {
            //usando mod
            double n;
            Console.WriteLine("digite um numero inteiro");
            n = double.Parse(Console.ReadLine());
            if ((int)n % 4 == 0)
            {
                Console.WriteLine("numero valido");
            }
            else
            {
                Console.WriteLine("numero invalido");
            }
        }
    }
}
