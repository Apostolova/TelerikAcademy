using System.Text;

namespace _2.Bank
{
   public class Customer
    {
       protected string FirstName { get; set; }
       protected string LastName { get; set; }

       public Customer()
       {
       }

       public Customer(string firstName, string lastName)
       {
           this.FirstName = firstName;
           this.LastName = lastName;
       }

       public override string ToString()
       {
           StringBuilder str = new StringBuilder();
           str.Append(this.FirstName + " ");
           str.Append(this.LastName);
           return str.ToString();
       }
    }
}
