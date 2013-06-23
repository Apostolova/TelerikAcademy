using System;
namespace _2.Bank
{
    class DepositAccount : Account, IDrawMoney, IDepositeMoney
    {
        public DepositAccount(Customer customer, double balance, double interestRate, DateTime start)
            : base(customer, balance, interestRate, new DateTime())
        {
        }

        public override double CalculateInterest()
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else return this.InterestRate;
        }

        public void Deposite(double sum)
        {
            this.Balance += sum;
        }

        public void Draw(double sum)
        {
            this.Balance -= sum;
        }
    }
}
