﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1usandowhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa a palavra de busca");
            var wordcount = FindByWhile(Console.ReadLine());
        }
    }
}
