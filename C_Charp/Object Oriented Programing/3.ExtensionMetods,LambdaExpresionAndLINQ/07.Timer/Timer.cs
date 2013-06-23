using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

//Using delegates write a class Timer that has can execute certain method at each t seconds.


namespace _07.Timer
{
    public delegate void TimerDelegate();

    class Timer
    {
        public static void RepeatMethod(TimerDelegate method, int seconds, int intervalT)
        {
            int start = 0;
            while (start <= intervalT)
            {
                method();
                Thread.Sleep(seconds*1000);
                start += seconds;
            }
        }

        public static void PrintConsole()
        {
            Console.WriteLine("Some time");
        }

        static void Main()
        {
            Timer.RepeatMethod(PrintConsole, 2, 20);

        }
    }
}
