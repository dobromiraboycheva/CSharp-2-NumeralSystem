//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter Binary number: ");
        long inputBinarylNumber = long.Parse(Console.ReadLine());
        long result = BinaryNumberToDecimal(inputBinarylNumber);
        Console.WriteLine(result);
    }
    static long BinaryNumberToDecimal(long binaryNumber)
    {
        long result = 0;
        int strNumber = binaryNumber.ToString().Length;
        for (int i = 0; i < strNumber; i++)
        {
            long lastDigit = binaryNumber % 10;
            result = result + lastDigit *(long)(Math.Pow(2, i));
            binaryNumber = binaryNumber / 10;
        }
        return result;
    }
}
