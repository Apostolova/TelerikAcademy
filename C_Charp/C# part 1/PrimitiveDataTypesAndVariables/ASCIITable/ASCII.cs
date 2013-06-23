using System;

class ASCII
{
    static void Main()
    {
        for (byte codeSymbol = 0; codeSymbol < 255; codeSymbol++)
        {
            char symbol = (char)codeSymbol;
            Console.WriteLine("Code: " + codeSymbol + " Symbol: " + symbol);
        }
    }
}

