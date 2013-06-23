using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AskName
{
    public static void YourName()
    {
        Console.WriteLine("What is your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", name);
    }
        
    static void Main()
    {
        Console.WriteLine("Now i ask you for your name :) ");
        YourName();
    }
}

