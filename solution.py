def count_bits_to_flip(a, b):
    xor = a ^ b
    count = 0
    while xor:
        count += xor & 1
        xor >>= 1
    return count