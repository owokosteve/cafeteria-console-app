namespace cafeconnect;

public class UserManager
{
    public static void AddUser(User user)
    {
        var db = FileDatabase.FileDatabaseInstance();
        db.SaveToFile(user, user.GetType().ToString(), "csv");
    }

    public static void Register()
    {
        Console.WriteLine("---Registraion---");
        Console.Write("Enter Username: ");
        string username = Console.ReadLine()!.Trim();
        Console.Write("Enter Fathers Name: ");
        string fatherName = Console.ReadLine()!.Trim();
        Console.Write("Enter Mobile Number: ");
        string mobile = Console.ReadLine()!.Trim();
        Console.WriteLine("Enter email: ");
        string mail = Console.ReadLine()!.Trim();
        // bool isValidMail = Regex.IsMatch(mail, @"^[a-zA-Z]+[a-zA-Z0-9-_.%]+@[a-zA-Z]{2,}\.[a-zA-Z]{2,}(\.?[a-zA-Z]{2,}$)*");
        Console.Write("Enter gender: (Male, Female)");
        Gender gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine()!.Trim(), true);
        Console.Write("Enter WorkStation Number: ");
        string wsno = Console.ReadLine()!.Trim();
        Console.Write("Enter Initial balance: ");
        decimal balance = decimal.Parse(Console.ReadLine()!.Trim());
        User user = User.GetUser();
        user.Name = username;
        user.FatherName = fatherName;
        user.Mobile = mobile;
        user.Mail = mail;
        user.Gender = gender;
        user.WorkStationNumber = wsno;
        user.RechargeWallet(balance);
        UserManager.AddUser(user);
        Console.WriteLine($"\nHello {user.Name}. Your UserID is {user.UserID}");
    }

    public static void Login()
    {
        Console.WriteLine("---User Login---");
        Console.Write("Enter User ID: ");
        string userId = Console.ReadLine()!.Trim();
        // var user = userDetails.Find(user => user.UserID == userId);
        var user = User.GetUser();
        if (user != null)
        {
            Console.WriteLine($"\nWelcome {user?.Name?.ToUpper()}");
            bool isContinue = true;
            do
            {
                Console.WriteLine("\n---HOMEPAGE---");
                Console.WriteLine($"\n[a] Show My Profile\n[b] Food Order\n[c] Modify Order\n[d] Cancel Order\n[e] Order History\n[f] Wallet Recharge\n[g] Show Wallet Balance");
                Console.Write("\nTo continue, choose options (a, b, c, d, e, f or g). To quit back press h: ");
                string choice = Console.ReadLine()!.Trim().ToLower();

                switch (choice)
                {
                    case "a":
                        user!.DisplayUser();
                        break;
                    case "b":
                        OrderManager.OrderFood(user!);
                        break;
                    case "c":
                        OrderManager.ModifyOrder(user!);
                        break;
                    case "d":
                        OrderManager.CancelOrder(user!);
                        break;
                    case "e":
                        // OrderManager.DisplayOrders(user!);
                        break;
                    case "f":
                        // Console.WriteLine("Wallet recharge");
                        Console.Write("Do you want to recharge your wallet? Reply with Yes or No: ");
                        string answer = Console.ReadLine()!.Trim().ToUpper();
                        Console.Write("Enter amount greater than 0 to recharge: ");
                        decimal amount = decimal.Parse(Console.ReadLine()!.Trim());
                        if (answer == "YES")
                        {
                            user!.RechargeWallet(amount);
                            Console.WriteLine($"\nSuccess. KES {amount} has been added to your account. New wallet balance is KES {user.WalletBalance}");
                        }
                        else
                        {
                            Console.WriteLine($"Good bye. You wallet balance is still KES {user!.WalletBalance}");
                        }
                        break;
                    case "g":
                        Console.WriteLine($"Your wallet balance is KES {user?.WalletBalance}");
                        break;
                    case "h":
                        isContinue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }

            } while (isContinue);
        }
        else
            Console.WriteLine("Invalid user ID");
    }

}