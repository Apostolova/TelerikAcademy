using System;


class AgeAfter
{
    static void Main()
    {
        uint Age = 0;
        Console.WriteLine("Въведете вашата възраст:");
        Age = uint.Parse ( System.Console.ReadLine());
        Console.WriteLine("След 10 години ще бъдете на:");
        Console.WriteLine(Age+10);
        
        
    }
}

