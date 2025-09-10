namespace cafeconnect;

public class Wallet
{
    public void AddFunds(User user)
    {
        do
        {
            Console.Write("\nWould you like to refund your wallet? \'YES or No\': ");
            string answer = Console.ReadLine()!.Trim().ToUpper();

            if (answer == "YES")
            {
                Console.Write("\nEnter amount greater than 1: ");
                do
                {
                    if (decimal.TryParse(Console.ReadLine()!, out decimal amount))
                    {
                        user.RechargeWallet(amount);
                        return;
                    }
                    else
                        Console.WriteLine("\nEnter a monetory value greater than 1");
                } while (true);
            }
            else if (answer == "NO")
            {
                Console.WriteLine("\nExiting due to insufficient balance.");
                return;
            }
            else { }
        } while (true);
    }
}