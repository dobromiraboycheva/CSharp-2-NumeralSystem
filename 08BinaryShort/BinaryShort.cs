//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        try
        {
            ushort number = ushort.Parse(Console.ReadLine());
            Console.WriteLine(inBinary(number));
        }
        catch (OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    static string inBinary(ushort s)
    {
        string bin = String.Empty;
        for (int i = 0; i < 16; i++)
        {
            bin = (s >> i & 1) + bin;
        }
        return bin;
    }   
}

