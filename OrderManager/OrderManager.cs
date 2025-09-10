namespace cafeconnect;

public class OrderManager
{
    public List<Food> GetFoods(User user, List<Food> foods) => foods;
    public static void AddOrder(User user, Order order)
    {
        var db = FileDatabase.FileDatabaseInstance();
        db.SaveToFile(user, order.GetType().ToString(), "csv");
    }
    public List<Order> GetOrders(User user, List<Order> orders, bool isGeneral) => orders;

    public static void AddToCart(User user, Cart cart)
    {
        var db = FileDatabase.FileDatabaseInstance();
        db.SaveToFile(user, cart.GetType().ToString(), "csv");
    }
    public List<Cart> GetCarts(User user, List<Cart> carts) => carts;
    public static void OrderFood(User user) { }
    public static void ModifyOrder(User user) { }
    public static void CancelOrder(User user) { }
    public void DisplayFood(List<Food> foods) => Console.WriteLine(foods);
    public static void DisplayOrders(User user, List<Order> orders) => Console.WriteLine(orders);
    public static void DisplayCarts(User user, List<Cart> carts) => Console.WriteLine(carts);
}
