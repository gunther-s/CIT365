﻿using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4; int y = 9;
            x = (y % x != 0) ? y / x : y;
            Console.WriteLine(x);
        }
    }
}
