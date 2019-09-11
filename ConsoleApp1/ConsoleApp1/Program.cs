using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            List<int> lista = new List<int>();
            int i = 3;
            stopwatch.Start();
            while (i <= 1000000)
            {
                int j = 3;
                while (j < i && i % j != 0)
                    j++;
                if (i == j)
                    lista.Add(i);
                i++;  
            }
            WriteLine($"Tempo passado: {stopwatch.Elapsed}");
            stopwatch.Stop();
            Console.ReadKey();
        }
    }
}
