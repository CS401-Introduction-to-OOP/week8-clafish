public class Parcel : DeliveryItem
{

    public string Dimensions;
    
    public Parcel(string trackingNumber, int weight, string dimensions) : base(trackingNumber, weight)
    {
        Dimensions = dimensions;
    }

    public override double CalculateCost() => 50 + Weight * 25;

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Size - {Dimensions}");
    }
}

