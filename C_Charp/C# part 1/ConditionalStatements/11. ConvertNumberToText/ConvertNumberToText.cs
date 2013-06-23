using System;

class ConvertNumberToText
{
    static void Main()
    {
        int tens = 0, ones = 0;
        string pronunciation = "";
        int numbers = int.Parse(Console.ReadLine());
        if ((numbers / 100) != 0)
        {
            ones = numbers / 100;
            switch (ones)
            {
                case 1:
                    pronunciation = pronunciation + "One hundred ";
                    break;
                case 2:
                    pronunciation = pronunciation + "Two hundred ";
                    break;
                case 3:
                    pronunciation = pronunciation + "Three hundred ";
                    break;
                case 4:
                    pronunciation = pronunciation + "Four hundred ";
                    break;
                case 5:
                    pronunciation = pronunciation + "Five hundred ";
                    break;
                case 6:
                    pronunciation = pronunciation + "Six hundred ";
                    break;
                case 7:
                    pronunciation = pronunciation + "Seven hundred ";
                    break;
                case 8:
                    pronunciation = pronunciation + "Eight hundred ";
                    break;
                case 9:
                    pronunciation = pronunciation + "Nine hundred ";
                    break;
            }
        }
        if (((numbers % 100) < 20) & ((numbers % 100) > 9))
        {
            tens = numbers % 100;
            if (pronunciation != "")
                pronunciation = pronunciation + "and ";
            switch (tens)
            {
                case 10:
                    pronunciation = pronunciation + "Ten ";
                    break;
                case 11:
                    pronunciation = pronunciation + "Eleven ";
                    break;
                case 12:
                    pronunciation = pronunciation + "Twelve ";
                    break;
                case 13:
                    pronunciation = pronunciation + "Thirteen ";
                    break;
                case 14:
                    pronunciation = pronunciation + "Fourteen ";
                    break;
                case 15:
                    pronunciation = pronunciation + "Fifteen ";
                    break;
                case 16:
                    pronunciation = pronunciation + "Sixteen ";
                    break;
                case 17:
                    pronunciation = pronunciation + "Seventeen ";
                    break;
                case 18:
                    pronunciation = pronunciation + "Eighteen ";
                    break;
                case 19:
                    pronunciation = pronunciation + "Nineteen ";
                    break;
            }
        }
        else
        {
            int a = numbers % 100;
            tens = a / 10;
            if (tens == 0)
                pronunciation = pronunciation + " and ";
            ones = numbers % 10;
            switch (tens)
            {
                case 2:
                    pronunciation = pronunciation + " Twenty ";
                    break;
                case 3:
                    pronunciation = pronunciation + " Thirty ";
                    break;
                case 4:
                    pronunciation = pronunciation + " Fourty ";
                    break;
                case 5:
                    pronunciation = pronunciation + " Fifty ";
                    break;
                case 6:
                    pronunciation = pronunciation + " Sixty ";
                    break;
                case 7:
                    pronunciation = pronunciation + " Seventy ";
                    break;
                case 8:
                    pronunciation = pronunciation + " Eighty ";
                    break;
                case 9:
                    pronunciation = pronunciation + " Ninty ";
                    break;
            }
            switch (ones)
            {
                case 0:
                    pronunciation = pronunciation + "Zero";
                    break;
                case 1:
                    pronunciation = pronunciation + "One ";
                    break;
                case 2:
                    pronunciation = pronunciation + "Two ";
                    break;
                case 3:
                    pronunciation = pronunciation + "Three ";
                    break;
                case 4:
                    pronunciation = pronunciation + "Four ";
                    break;
                case 5:
                    pronunciation = pronunciation + "Five ";
                    break;
                case 6:
                    pronunciation = pronunciation + "Six  ";
                    break;
                case 7:
                    pronunciation = pronunciation + "Seven ";
                    break;
                case 8:
                    pronunciation = pronunciation + "Eight  ";
                    break;
                case 9:
                    pronunciation = pronunciation + "Nine ";
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(pronunciation);
   }
}

  
