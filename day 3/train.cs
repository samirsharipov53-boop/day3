public class Train : Transport
{
    public int Vagon;
    public Train(){}
    public Train(int v)
    {
        Vagon=v;
    }

    public Train(string fl, int p, string r) : base(fl, p, r)
    {
    }
}