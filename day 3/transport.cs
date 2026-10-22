public class Transport
{
 public string? Fueltype{get;set;}   
 public int Probeg{get;set;}
 public string? RoadType{get;set;}
 public Transport(){}
 public Transport(string fl, int p, string r)
    {
        Fueltype=fl;
        Probeg=p;
        RoadType=r;
    }
}