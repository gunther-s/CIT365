using System;

namespace test1
{
    enum Test { A, B, C = 5, D };
    static void Main(string[] args)
    {
        int x = (int)Test.D;
        Console.WriteLine(x);
    }
}
