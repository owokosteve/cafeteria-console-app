namespace cafeconnect;

public enum OrderStatus
{
    Default,
    Initiated,
    Ordered,
    Cancelled
}
public class Order(string userId, DateTime date, decimal price, OrderStatus orderStatus)
{
    private static int _counter = 1001;
    public string OrderID { get; } = $"OID{_counter++}";
    public string UserID { get; set; } = userId;
    public DateTime OrderDate { get; set; } = date;
    public decimal TotalPrice { get; set; } = price;
    public OrderStatus OrderStatus { get; set; } = orderStatus;
    public override string ToString() => "orders";
}