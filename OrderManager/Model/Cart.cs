namespace cafeconnect;

public class Cart(string orderId, string foodId, decimal orderPrice, int orderQty)
{
    private static int _counter = 101;
    public string ItemID { get; } = $"ITID{_counter++}";
    public string OrderID { get; set; } = orderId;
    public string FoodID { get; set; } = foodId;
    public decimal OrderPrice { get; set; } = orderPrice;
    public int OrderQuantity { get; set; } = orderQty;
    public override string ToString() => "carts";
}
