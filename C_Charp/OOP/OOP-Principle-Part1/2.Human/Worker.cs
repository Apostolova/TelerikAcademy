using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
     public class Worker : Humans
    {
        public decimal weekSalary;
        public int workHoursPerDay;

        public Worker()
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary / (5 * this.WorkHoursPerDay);
            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(this.firstName + " ");
            str.Append(this.lastName + " ");
            str.Append(this.weekSalary + " ");
            str.Append(this.workHoursPerDay);
            return str.ToString();
        }
        
    }
}