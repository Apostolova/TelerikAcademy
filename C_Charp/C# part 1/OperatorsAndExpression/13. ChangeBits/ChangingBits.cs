using System;

class ChangingBits
{
    static void Main()
    {
        Console.WriteLine("Please enter a unsigned iginteger number!");
        uint number = uint.Parse(Console.ReadLine());
        uint bit3 = (number & (1u << 3)) >> 3;
        uint bit4 = (number & (1u << 4)) >> 4;
        uint bit5 = (number & (1u << 5)) >> 5;
        uint bit24 = (number & (1u << 24)) >> 24;
        uint bit25 = (number & (1u << 25)) >> 25;
        uint bit26 = (number & (1u << 26)) >> 26;
        uint modifyNumber = number & (~(1u << 3)) & (~(1u << 4)) & (~(1u << 5)) & (~(1u << 24)) & (~(1u << 25)) & (~(1u << 26));
        uint result = modifyNumber | (bit3 << 24) | (bit4 << 25) | (bit5 << 26) | (bit24 << 3) | (bit25 << 4) | (bit26 << 5);
        Console.WriteLine("The binary representation of your number ({0}) is :\n{1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("The binary representation of modify number ({0}) is :\n{1}", result, Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
