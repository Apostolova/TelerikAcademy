using System;

class DifferentVariables
{
    static void Main()
    {

        Console.WriteLine("Enter to choice:");
        Console.WriteLine("1 for int, 2 for double or 3 for string:");
        Console.WriteLine("Your choice is:");
        int choice = int.Parse(Console.ReadLine()); 
        switch (choice)
        {
            case 1:
                Console.WriteLine("Your choice is integer:");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}", i+1);
            break;
            case 2: 
                Console.WriteLine("Your choice is double:");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("{0}", d+1d);
            break;
            case 3:
                Console.WriteLine("Your choice is string:");
                string s = Console.ReadLine();
                    Console.WriteLine("{0}", s +'*');
            break;
        }
    }
}

