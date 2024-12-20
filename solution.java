Here is a Java console application that solves the problem:

```java
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter the first integer:");
        int num1 = scanner.nextInt();
        System.out.println("Enter the second integer:");
        int num2 = scanner.nextInt();
        System.out.println("Number of bits to flip: " + countBitsToFlip(num1, num2));
    }

    private static int countBitsToFlip(int num1, int num2) {
        int xor = num1 ^ num2;
        int count = 0;
        while (xor != 0) {
            count += xor & 1;
            xor >>= 1;
        }
        return count;
    }
}
```

This program first takes two integers as input from the user. It then calculates the XOR of these two numbers. The XOR operation gives a number which has 1s at all the places where the two numbers have differing bits. The program then counts the number of 1s in this number, which is the number of bits that need to be flipped to convert one number to the other.