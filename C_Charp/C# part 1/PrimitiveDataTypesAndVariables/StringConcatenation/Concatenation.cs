using System;

class Concatenation
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object concatenation = a + " " + b;
        string c = (string)concatenation;
        Console.WriteLine(c);
    }
}

