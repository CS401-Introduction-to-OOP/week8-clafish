public abstract class DeliveryItem
{
    public string TrackingNumber;
    public int Weight;

    public DeliveryItem(string trackingNumber, int weight)
    {
        TrackingNumber = trackingNumber;
        Weight = weight;
    }

    public abstract double CalculateCost();

    public virtual void PrintInfo() => Console.WriteLine($"The delivery tracking number = {TrackingNumber}, weight - {Weight}");
}