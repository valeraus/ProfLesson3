using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            BitArray bits = new BitArray(3);
            bits[0] = false;
            bits[1] = true;
            bits[2] = false;
            Console.Write(bits.Length);
            bits.Length = 4;
            bits[3] = true;
            Console.Write(bits.Length);
            Console.ReadKey();
        }
    }
}
