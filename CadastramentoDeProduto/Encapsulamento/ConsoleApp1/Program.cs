﻿using System;
using System.Globalization;

using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1350, 10);
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome()); 
            Console.WriteLine(p.GetPreco());
        }
    }
}