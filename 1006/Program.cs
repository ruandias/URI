﻿using System;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double media = (A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine("MEDIA = {0}", media.ToString("N1"));
        }
    }
}
