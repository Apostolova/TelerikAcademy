using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    public class LoanAccount : Account, IDepositeMoney
    {
        private DateTime start { get; set; }

        public LoanAccount(Customer customer, double balance, double interestRate, DateTime start)
            : base(customer, balance, interestRate, new DateTime())
        {
        }


        public override double CalculateInterest()
        {
            int totalMonth = TotalMonth(start);

            if (this.Customer is IndividualCustomer)
            {
                if ((DateTime.Today.Month - start.Month) <= 3)
                {
                    return this.interestRate * (totalMonth - 3);
                }
                else
                {
                    return this.interestRate * totalMonth;
                }
            }
            if (this.Customer is CompaniesCustomer)
            {
                if ((DateTime.Today.Month - start.Month) <= 2)
                {
                    return this.interestRate * (totalMonth - 2);
                }
                else
                {
                    return this.interestRate * totalMonth;
                }
            }
            else
               throw new ArgumentException("Inccorect client");
        }

        public void Deposite(double sum)
        {
            this.Balance += sum; 
        }
    }
}
