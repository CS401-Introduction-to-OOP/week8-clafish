namespace _123.week8_clafish.Week8;

public class Program
{
    public static void Main(String[] args)
    {
        var letter1 = new Letter("A1", 1);
        var letter2 = new Letter("A2", 2);

        var parcel1 = new Parcel("B1", 69, "175x900x15");
        var parcel2 = new Parcel("B2", 80, "155x800x15");
        
        letter1.PrintInfo();
        Console.WriteLine();
        parcel2.PrintInfo();

        CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();
        
        myCargo.AddItem(letter1);
        myCargo.AddItem(letter2);
        myCargo.AddItem(parcel1);
        myCargo.AddItem(parcel2);

        Console.WriteLine($"Total cost will be {myCargo.GetTotalCost()}");
    }
}