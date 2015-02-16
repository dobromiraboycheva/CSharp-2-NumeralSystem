//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representatio

using System;
using System.Collections.Generic;
using System.Linq;
  
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter Hexadecimal number: ");
        string inputBinarylNumber = Console.ReadLine();
        long result = HexadecimalNumberToDecimal(inputBinarylNumber);
        Console.WriteLine(result);
    }
    static long HexadecimalNumberToDecimal(string binaryNumber)
    {
        long result = 0;
        int count = binaryNumber.Length - 1;
        int digit = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            switch (binaryNumber[i])
            {
                case 'A':
                case 'a': digit = 10; break;
                case 'B':
                case 'b': digit = 11; break;
                case 'C':
                case 'c': digit = 12; break;
                case 'D':
                case 'd': digit = 13; break;
                case 'E':
                case 'e': digit = 14; break;
                case 'F':
                case 'f': digit = 15; break;
                default: digit = int.Parse(Convert.ToString(binaryNumber[i])); 
                    break;
            }
            result += digit *(long)Math.Pow(16,count);
            count--;
        }
        return result;
    }
}