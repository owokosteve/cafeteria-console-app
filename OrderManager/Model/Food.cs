namespace cafeconnect;

public class Food(string fname, decimal price, int qty)
{
    private static int _counter = 101;
    public string FoodID { get; } = $"FID{_counter++}";
    public string FoodName { get; set; } = fname;
    public decimal FoodPrice { get; set; } = price;
    public int AvailableQuantity { get; set; } = qty;
    public override string ToString() => "food";
}