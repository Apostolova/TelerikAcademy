
public class Display
{
    private double size;
    private int colors;

    //constructors

    public Display(double size, int colors)
    {
        this.size = size;
        this.colors = colors;
    }

    public Display(double size)
    {
        this.size = size;
        this.colors = 0;
    }

    //properties

    public double Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public int Colors
    {
        get { return this.colors; }
        set { this.colors = value; }
    }


}




