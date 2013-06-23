using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In comment, because we can't have two main methods

namespace MobilePhone
{
   public class GSMCallHistoryTest
    {
       static void Main()
       {
           GSM firstGSM = new GSM("sony experia", "Sony", 240, "me");
           GSM[] GSMs = new GSM[] { firstGSM };

           firstGSM.AddingCalls(new Call(new DateTime(2013, 02, 15, 20, 15, 30), "0985 15 26 18", 142));
           firstGSM.AddingCalls(new Call(new DateTime(2013, 02, 15, 20, 16, 30), "0985 15 23 18", 100));

           Console.WriteLine(firstGSM.CallHistoryInfo());
           

           decimal fixedPrice = 0.37m;
           Console.WriteLine("All price: {0:C}", firstGSM.CalculatePricePerMinute(fixedPrice));
           Console.WriteLine();

           firstGSM.DeleteLongestCalls();
           Console.WriteLine(firstGSM.CallHistoryInfo());
           Console.WriteLine("All price: {0:C}", firstGSM.CalculatePricePerMinute(fixedPrice));

           firstGSM.ClearHistory();
           Console.WriteLine(firstGSM.CallHistoryInfo());
       }
    }
}
