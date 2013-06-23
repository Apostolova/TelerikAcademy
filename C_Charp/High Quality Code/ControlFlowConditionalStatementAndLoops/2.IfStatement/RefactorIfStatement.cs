namespace _2.IfStatement
{
    using System;
    using System.Linq;
    using _1.Cooking;
    
    public class RefactorIfStatement
    {
        public const int MaxColomn = int.MaxValue;
        public const int MaxRow = int.MaxValue;
        public const int MinColomn = int.MinValue;
        public const int MinRow = int.MinValue;

       public static void Main(string[] args)
        {
             ////task 1

            Potato potato = new Potato();
            if (potato != null)
            {
                if (potato.IsPeeled && potato.IsFresh)
                {
                    Cook(potato);
                }
            }

             ////task 2
            
            int row = int.Parse(Console.ReadLine());
            int colomn = int.Parse(Console.ReadLine());
            bool shoudlVisitCell = true;
            bool inColomn = (MinColomn <= colomn) && (colomn <= MaxColomn);
            bool inRow = (MinRow <= row) && (row  <= MaxRow);
            if (inRow && inColomn && shoudlVisitCell)
            {
               VisitCell();
            }
        }

        public static void Cook(Vegetable vegetable)
        {
            vegetable.IsCooked = true;
        }

        public static void VisitCell()
        {
        }
    }
}
