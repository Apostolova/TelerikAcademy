using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
   public class Program
    {
        static void Main()
        {

            Worker Worker1 = new Worker("Elena", "Apostolova", 250, 40);
            Worker worker2 = new Worker("Elena", "Aapostolova", 280, 40);
            //Worker Worker3 = new Worker("Mila", "kpostolova", 150, 42);
            //Worker Worker4 = new Worker("lena", "postolova", 240, 38);
            //Worker Worker5 = new Worker("ena", "Apostolova", 350, 50);
            //Worker[] workers = new Worker { }; // { Worker1, worker2, Worker3, Worker4, Worker5 };

            //var ByMoney = workers.OrderByDescending(x => x.MoneyPerHour());
            //foreach (Worker item in workers)
            //{
            //    Console.WriteLine(item.firstName, item.lastName);
            //}
        }
    }
}
