using System;

public class Battery
{
    private string model;
    private BatteryType type;
    private string hourIdle;
    private string hourTalk;

    /// constructors
    public Battery(string model, string hourIdle, string hourTalk)
    {
        this.model = model;
        this.hourIdle = hourIdle;
        this.hourTalk = hourTalk;
    }

    public Battery(string model, BatteryType type, string hourIdle, string hourTalk)
    {
        this.type = type;
        this.model = model;
        this.hourIdle = hourIdle;
        this.hourTalk = hourTalk;
    }

    public Battery(BatteryType type)
    {
        this.type = type;
    }

    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }

    /// properties
    public BatteryType Type
    {
        get { return this.type; }
        set { this.type = value; }
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public string HourIdle
    {
        get { return this.hourIdle; }
        set { this.hourIdle = value; }
    }

    public string HourTalk
    {
        get { return this.hourTalk; }
        set { this.hourTalk = value; }
    }
}
