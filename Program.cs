namespace cafeconnect;

public class Program
{
    public static void Main(string[] args)
    {
       
        Console.WriteLine("\n---WELCOME TO CAFE CONNECT---");
        bool isContinue = true;
        do
        {
            Console.WriteLine("\n[1] User Registration\n[2] User Login\n[3] Exit");
            Console.Write("Choose options (1, 2 or 3): ");
            string choice = Console.ReadLine()!.Trim();
            switch (choice)
            {
                case "1":
                    UserManager.Register();
                    break;
                case "2":
                    UserManager.Login();
                    break;
                case "3":
                    Console.WriteLine("Exiting...");
                    isContinue = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    break;
            }
        } while (isContinue);

    }

}