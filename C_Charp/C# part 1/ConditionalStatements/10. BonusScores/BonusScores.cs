using System;

class BonusScores
{
    static void Main()
    {
        int range = int.Parse(Console.ReadLine());
        switch (range)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("Bonus scores is : {0}", range * 10);
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Bonus scores is : {0}", range * 100);
                break;
            case 7:
            case 8:
            case 9:
                Console.WriteLine("Bonus scores is : {0}", range * 1000);
                break;
            case 0:
                Console.WriteLine("Error");
                break;
            default:
                Console.WriteLine("Error");
                break;
        }

    }
}
