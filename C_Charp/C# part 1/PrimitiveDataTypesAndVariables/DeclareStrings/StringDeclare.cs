using System;

class StringDeclare
{
    static void Main()
    {
        string expression = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(expression);
        string expression1 = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(expression1);
    }
}

