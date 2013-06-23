using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank
{
    class MortgageAccount : Account, IDepositeMoney
    {
      
        private DateTime start {get; set;}

        public MortgageAccount(Customer customer, double balance, double interestRate, DateTime start)
            : base(customer, balance, interestRate, new DateTime())
        {
        }


        public override double CalculateInterest()
        {
            int totalMonth = TotalMonth(start);
            if (this.Customer is CompaniesCustomer)
            {
                if ((DateTime.Today.Month - start.Month) > 12)
                {
                    return totalMonth * this.interestRate;
                        
                }
                else
                    return (12 * this.interestRate * 0.5) + ((totalMonth - 12) * this.interestRate);
            }
            if (this.Customer is IndividualCustomer)
            {
                if ((DateTime.Today.Month - start.Month) <= 6)
                {
                    return this.interestRate * (totalMonth - 6);
                }
                else
                {
                    return this.interestRate * totalMonth;
                }
            }
            else throw new ArgumentException("Ïnccorect client");
        }

        public void Deposite(double sum)
        {
            this.Balance += sum;
        }
                
    }
}
