public class Letter : DeliveryItem
{
    public Letter(string trackingNumber, int weight) : base(trackingNumber, weight)
    {
    }

    public override double CalculateCost() => 15 + (Weight * 10);
}