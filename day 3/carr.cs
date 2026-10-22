public class Carr : Transport
{
    public string Mark;
    public Carr(){}
    public Carr(string m)
    {
        Mark=m;
    }
    public Carr(string fl, int p, string r) : base(fl, p, r)
    {
    }
}