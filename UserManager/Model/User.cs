namespace cafeconnect;

public sealed class User : PersonalDetials, IBalance
{
    private static int Counter = 1001;
    public string UserID { get; }
    private static User? UserInstance = null;
    public string? WorkStationNumber { get; set; }
    private decimal _balance;
    public decimal WalletBalance => _balance;
    private User() => UserID = $"{Counter++}";
    public static User GetUser()
    {
        if (UserInstance == null)
        {
            UserInstance = new User();
        }
        return UserInstance;
    }

    public void RechargeWallet(decimal amount)
    {
        if (amount > 0)
            _balance += amount;
        else
            Console.WriteLine("Sorry! Minimum amount to recharge is 1");
    }
    public bool DeductAmount(decimal amount)
    {
        if (amount > 0 && _balance >= amount)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }
    public void DisplayUser()
    {
        var user = GetUser();
        Console.WriteLine($"\n---{user.Name?.ToUpper()} DETAILS---");
        Console.WriteLine($"FULL NAME: {user?.Name} {user?.FatherName}\nUSER ID: {user?.UserID}\nPHONE: {user?.Mobile}\nEMAIL: {user?.Mail}\nGENDER: {user?.Gender}\nWSNO: {user?.WorkStationNumber}\nBALANCE: {user?.WalletBalance}");
    }
    public override string ToString() => "users";

}
