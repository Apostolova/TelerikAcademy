namespace ComparePerformanceOfvalueType
{
    using System;
    using System.Linq;

   public class TestPerformance
    {
        public static void Main()
        {
            AddMethods.AddDecimal(4m, 10000m);
            AddMethods.AddDouble(4d, 10000d);
            AddMethods.AddFloat(4f, 10000f);
            AddMethods.AddInt(4, 10000);
            AddMethods.AddLong(4L, 10000L);

            SubstractMethods.SubstractDecimal(10000m, 4m);
            SubstractMethods.SubstractDouble(10000d, 4d);
            SubstractMethods.SubstractFloat(10000f, 4f);
            SubstractMethods.SubstractInt(10000, 4);
            SubstractMethods.SubstractLong(10000L, 4L);

            MultiplyMethods.MultiplyDecimal(2m, 10000m, 2m);
            MultiplyMethods.MultiplyDouble(2d, 10000d, 5d);
            MultiplyMethods.MultiplyFloat(2f, 10000f, 5f);
            MultiplyMethods.MultiplyInt(2, 10000, 5);
            MultiplyMethods.MultiplyLong(2L, 10000L, 5L);

            DivideMethods.DivideDecimal(10000m, 4m, 2m);
            DivideMethods.DivideDouble(10000d, 4d, 2d);
            DivideMethods.DivideFloat(10000f, 4f, 2f);
            DivideMethods.DivideInt(10000, 4, 2);
            DivideMethods.DivideLong(10000L, 4L, 2L);
        }
    }
}
