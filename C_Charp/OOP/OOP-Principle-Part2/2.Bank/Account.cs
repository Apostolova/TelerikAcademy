using System;
using System.Collections;
using System.Text;

namespace _2.Bank
{
    public abstract class Account 
    {
        private Customer customer;
        private double balance;
        protected double interestRate;
        private DateTime Start {get; set; }

        //constructors
        public Account () : this(new Customer(),0, 0, new DateTime())
            {
            }

        public Account(Customer customer, double balance, double interestRate, DateTime start) 
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.Start = start;
        }

        //properties
        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        //methods

        public virtual int TotalMonth(DateTime start)
        {
            int startMonth = start.Month;
            int startYear = start.Year;
            DateTime today = DateTime.Today;

            return ((today.Year - startYear) * 12 + (today.Month - startMonth));

        }

        public virtual double CalculateInterest()
        {
            int totalMonth = TotalMonth(Start);
            return totalMonth * interestRate;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append( "Customer: " + this.customer);
            str.AppendLine();
            str.Append("Balance: " + this.balance);
            str.AppendLine();
            str.Append("Interest rate: " + this.interestRate);
            return str.ToString();

        }
    }

}
