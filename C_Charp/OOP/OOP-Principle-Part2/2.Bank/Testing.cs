using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class Testing
    {
        static void Main()
        {
            Account[] Bank = new Account[]
            {
                new DepositAccount(new IndividualCustomer("Ivan", "Ivanov"), 1200, 0.15, new DateTime(18/02/2010)),
                new LoanAccount(new CompaniesCustomer("Telerik"), 2000, 0.10, new DateTime(20/10/2000)),
                new MortgageAccount(new IndividualCustomer("Pesho", "Peshev"), 3000, 0.20, new DateTime(01/01/2012)),
                    };
            foreach (Account item in Bank)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.CalculateInterest());
            }

            LoanAccount user1 = new LoanAccount(new IndividualCustomer("Ivan", "Ivanov"), 1200, 0.15, new DateTime(15 / 03 / 2013));
            Console.WriteLine(user1.GetType());
            Console.WriteLine(user1);
            Console.WriteLine(user1.CalculateInterest());

            Console.WriteLine(user1.CalculateInterest());


            MortgageAccount user2 = new MortgageAccount(new IndividualCustomer("Ivan", "Ivanov"), 1200, 0.15, new DateTime(18/03/2014));
            Console.WriteLine(user2.GetType());
            Console.WriteLine(user2);
            Console.WriteLine(user2.CalculateInterest());
            user2.Deposite(1000);
            Console.WriteLine(user2.CalculateInterest());
            Console.WriteLine(user2.Balance);
        }
    }
}
