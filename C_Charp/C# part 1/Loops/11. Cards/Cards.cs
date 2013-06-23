using System;

class Cards
{
    static void Main()
    {
        string numbers = "", suits = "";
        for (int i=1; i<5; i++)
        {
            switch (i)
            {
                case 1 : 
                    suits = "Spades ";
                    break;
                case 2 :
                    suits = "Hearts ";
                    break;
                case 3 :
                    suits = "Diamonds";
                    break;
                case 4 :
                    suits = "Clubs";
                    break;
            }
            Console.WriteLine();
            for (int j=2; j<15; j++)
            {
        switch (j)
        {
            case 2 :
                numbers = "Two";
                break;
            case 3 :
                numbers = "Three";
                break;
            case 4 :
                numbers = "Four";
                break;
            case 5 :
                numbers = "Five";
                break;
            case 6 :
                numbers = "Six";
                break;
            case 7 :
                numbers = "Seven";
                break;
            case 8 :
                numbers = "Eight";
                break;
            case 9 :
                numbers = "Nine";
                break;
            case 10 :
                numbers = "Ten";
                break;
            case 11 :
                 numbers ="Jack";
                break;
            case 12 :
                numbers ="Queen";
                break;
            case 13 :
                numbers ="King";
                break;
            case 14 :
                numbers ="Ace";
                break;
        }
                Console.WriteLine("{0} of {1}", numbers, suits);
            }
        }
    }
}

