Here is a Python console application that solves the problem:

```python
def count_bits_to_flip(a, b):
    xor = a ^ b
    count = 0
    while xor:
        count += xor & 1
        xor >>= 1
    return count

def main():
    a = int(input("Enter the first integer: "))
    b = int(input("Enter the second integer: "))
    print("Number of bits to flip: ", count_bits_to_flip(a, b))

if __name__ == "__main__":
    main()
```

This application first takes two integers as input from the user. It then calculates the XOR of these two integers. The XOR operation gives a binary number where each bit is 1 if the corresponding bits in the two integers are different. The application then counts the number of 1s in this binary number, which is the number of bits that need to be flipped to convert one integer to another.