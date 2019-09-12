using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoFor
{
    class Program
    {
        static void Main(string[] args)		
        {
            var nome = " Silvana";
            var countFind = 0; 

            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine($"{nome[i-1]}-{nome[i]}-{nome[i+1]}");
                if ((nome[i-1].ToString() +nome[i].ToString()) == "un")countFind++;
            }
            Console.ReadKey();

        }
    }
}
