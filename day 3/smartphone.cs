public class SmartPhone : Computer
{
    string? field;

    public SmartPhone()
    {
    }

    public SmartPhone(string a)
    {
        field=a;
    }

    public SmartPhone(int r, int s, string a) : base(r, s, a)
    {
    }
    public string TakeSelfier()
    {
        return field;
    }
}