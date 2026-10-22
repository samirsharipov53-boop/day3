public class Computer
{
    public int Ram{get;set;}
    public int Storage{get;set;}
    string? Keyboard{get;set;}
    public Computer(){}
    public Computer(int r, int s, string a)
    {
        Ram=r;
        Storage=s;
        Keyboard=a;
    }
    public void AddRam(int a)
    {
        Ram=a;
    }
    public void AddStorage(int a)
    {
        Storage=a;
    }
}