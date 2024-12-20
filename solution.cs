Here is a simple console application in C# that solves the problem:

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second integer: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int xor = num1 ^ num2;
        int count = 0;

        while (xor != 0)
        {
            count += xor & 1;
            xor >>= 1;
        }

        Console.WriteLine("Number of bits to flip: " + count);
    }
}
```

This program works by first taking two integers as input from the user. It then calculates the XOR of these two integers. The XOR operation will result in a binary number where each bit is 1 if the corresponding bits in the two input numbers are different, and 0 if they are the same. Therefore, the number of 1s in the XOR result is the number of bits that need to be flipped to convert one number to the other. The program then counts the number of 1s in the XOR result by repeatedly checking the least significant bit and then right-shifting the number.