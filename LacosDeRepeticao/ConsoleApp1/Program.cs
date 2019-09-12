using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            while (count <450 )
            {
                Console.WriteLine($"numero:{count}");
                count++; 
                //enterno

            }
            Console.WriteLine(  " Terminou o loop");
            Console.ReadKey();
        }


    }
}
