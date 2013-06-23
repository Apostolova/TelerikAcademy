namespace MobilePhone
{
    using System;
    using System.Linq;

   public class Call
    {
       private DateTime dateTime;
       private string dialtedNumbers;
       private short duration;

      /// constructor
       public Call(DateTime dateTime, string dialedNumbers, short duration)
       {
           this.dateTime = dateTime;
           this.dialtedNumbers = dialedNumbers;
           this.duration = duration;
       }

       /// properties
       public DateTime DateTime
       {
           get { return this.dateTime; }
           set { this.dateTime = value; }
       }

       public string DialtedNumbers
       {
           get { return this.dialtedNumbers; }
           set { this.dialtedNumbers = value; }
       }

       public short Duration
       {
           get { return this.duration; }
           set { this.duration = value; }
       }
    }
}
