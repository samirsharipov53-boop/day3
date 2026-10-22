public class Car : Product
{
    string? fueltype;
    public Car()
    {
    }

    public Car(string n, double f) : base(n, f)
    {
    }
    public Car(string n, double f, string fuel) : base(n, f)
    {
        fueltype=fuel;
    }
}