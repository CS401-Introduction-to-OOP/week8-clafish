namespace _123.week8_clafish.Week8;

public class CargoContainer<T> where T : DeliveryItem
{
    private List<T> container = new();

    public void AddItem(T item)
    {
        container.Add(item);
    }

    public double GetTotalCost()
    {
        double sum = 0;
        foreach (var delivery in container)
        {
            sum += delivery.CalculateCost();
        }

        return sum;
    }
}