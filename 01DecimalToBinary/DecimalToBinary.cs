//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinary
{

    static void Main()
    {
        Console.WriteLine("Enter Decimal number: ");
        string inputDecimalNumber = Console.ReadLine();
        long decimalNumber = long.Parse(inputDecimalNumber);

        if (decimalNumber < 0)
        {
            decimalNumber = decimalNumber ^ long.MinValue;
        }
        string result = DecimalNumberToBinary(decimalNumber);
        Console.WriteLine(result);
    }
    static string DecimalNumberToBinary(long decimalNumber)
    {
        string result = string.Empty;
        if (decimalNumber != 0)
        {
            result = null;
            while (decimalNumber != 0)
            {
                byte remainder = (byte)(decimalNumber % 2);
                result = remainder + result;
                decimalNumber /= 2;
            }

            int fillByte = result.Length % 4;
            for (int i = 0; i < fillByte; i++)
            {
                result = "0" + result;
            }
        }
        return result;
    }
}

