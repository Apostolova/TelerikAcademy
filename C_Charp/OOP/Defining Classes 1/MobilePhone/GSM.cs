using System.Text;
using System;

using System.Collections.Generic;
using System.IO.Compression;
using MobilePhone;
using System.Globalization;


public class GSM
{
    private string model;
    private string manufactures;
    private decimal price;
    private string owner;
    public Battery Battery = new Battery(null, null, null);
    private Display Display = new Display(0.0, 0);
    public List<Call> callHistory = new List<Call>();
   

    static GSM iPhone4S = new GSM("iPhone4S", "Apple", 1000, "Me",new Battery("OEM", "300", "8"), new Display(3.5, 16000));

    //constructors

    public GSM(string model, string manufactures, decimal price, string owner)
    {
        this.model = model;
        this.manufactures = manufactures;
        this.price = price;
        this.owner = owner;
    }

    public GSM(string model, string manufactures, decimal price, string owner, Battery battery, Display display)
    {
        this.model = model;
        this.manufactures = manufactures;
        this.price = price;
        this.owner = owner;
        this.Battery.Type = battery.Type;
        this.Battery.Model = battery.Model;
        this.Battery.HourIdle = battery.HourIdle;
        this.Battery.HourTalk = battery.HourTalk;
        this.Display.Colors = display.Colors;
        this.Display.Size = display.Size;

    }

    //properties
   
    public static GSM IPnone4S
    {
        get { return iPhone4S; }
    }

    public string Model
    {
        get
        {
            return this.model;
        }

        set
        {
            if (value != null)
            {
                this.model = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public string Manufactures
    {
        get
        {
            return this.manufactures;
        }

        set
        {
            if (value != null)
            {
                this.manufactures = value;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Incorrect price, must be bigger than zero");
            }
            else
            {
                this.price = value;
            }
        }
    }

    public string Owner
    {
        get { return this.owner; }
        set { this.owner = value; }

    }

    public List<Call> CallHistory
    {
        get { return this.callHistory; }
        set { this.callHistory = value; }
    }

    //methods

    
    public void AddingCalls(Call call)
    {
        this.callHistory.Add(call);
    }

  
    public void DeleteLongestCalls()
    {
        int counter = 0;
        int index = 0;
        short maxDuration = 0;
        foreach (Call call in callHistory)
        {
            if (call.Duration > maxDuration)
            {
                maxDuration = call.Duration;
                index = counter;
            }
            counter++;
        }
        if (index == 0)
        {
            this.callHistory.RemoveAt(0);
        }
        else
        {
            this.callHistory.RemoveAt(index);
        }

    }

 
    public void ClearHistory()
    {
        this.callHistory.Clear();
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();

        str.Append("GSM model:" + " " + model + Environment.NewLine);
        str.Append("Manufactures:" + " " + manufactures + Environment.NewLine);
        str.Append("Price:" + " " + price + ".лв" + Environment.NewLine);
        str.Append("Owner:" + " " + owner + Environment.NewLine);
        str.Append("Battery Type:" + " " + Environment.NewLine);
        str.Append("Battery Model:" + " " + Battery.Model + Environment.NewLine);
        str.Append("Battery Hour Idle:" + " " + Battery.HourIdle + "hrs" + Environment.NewLine);
        str.Append("Battery  Hour Talk:" + " " + Battery.HourTalk + "hrs" + Environment.NewLine);
        str.Append("Display Size:" + " " + Display.Size + "inches" + Environment.NewLine);
        str.Append("Display Colors:" + " " + Display.Colors + "K" + Environment.NewLine);

        return str.ToString();
    }



    public string CallHistoryInfo()
    {
        StringBuilder me = new StringBuilder();
        foreach (Call call in callHistory)
        {
           
            me.Append("Call date and time:" + " " + call.DateTime + Environment.NewLine);
            me.Append("Dialed Numbers:" + " " + call.DialtedNumbers + Environment.NewLine);
            me.Append("Duration:" + " " + call.Duration + "sec" + Environment.NewLine);
        }
            return me.ToString();
    }

    //Methods calculate a total price of all call in callHistory. 
    //Assume the price per minute is fixed and is provided as a parameter.


    public decimal CalculatePricePerMinute(decimal fixedPrice)
    {
        decimal sum = 0;
        foreach (Call call in CallHistory)
        {
            sum += call.Duration;
        }
       decimal rezult = (sum / 60) * fixedPrice;
       return rezult;
    }
}



