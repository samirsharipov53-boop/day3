public class Laptop : Computer
{
    double weight;
    public Laptop(){}
    public Laptop(double w)
    {
        weight=w;
    }

    public Laptop(int r, int s, string a) : base(r, s, a)
    {
    }
    public double CheckWeight()
    {
        return weight;
    }
}