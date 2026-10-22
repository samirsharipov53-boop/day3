public class Plane : Transport
{
    int Heith;
    public Plane(int h)
    {
        Heith=h;
    }
    public Plane(){}

    public Plane(string fl, int p, string r) : base(fl, p, r)
    {
    }
}