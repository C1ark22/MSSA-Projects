using System.Security.Cryptography.X509Certificates;

namespace ChallengeLab2._2
{
    public class UserAccount
    {
        public string UserID {  get; set; }
        public string Password { get; set; }

        public UserAccount(string username, string password)
        {
            UserID = username;
            Password = password;
        }

        public bool IsLoginValid(string inputUserID, string inputPassword)
        {
            return inputUserID == UserID && inputPassword == Password;
        }
    }

    public class LoginManager
    {
        private const int MaxAttempts = 3;

        public bool Login(UserAccount account)
        {
            int attempts = 0;

            // login section
            while (attempts < MaxAttempts)
            {
                Console.Write("Enter your User ID to login: ");
                string inputUserID = Console.ReadLine() ?? "";

                Console.Write("Enter your password to login: ");
                string inputPassword = Console.ReadLine() ?? "";

                if (account.IsLoginValid(inputUserID,inputPassword))
                {
                    return true;
                }
                attempts++;

                int remainingAttempts = MaxAttempts - attempts;

                if (remainingAttempts > 0)
                {
                    Console.WriteLine($"Incorrect UserID or password. You have {remainingAttempts} attempts left.");
                }
                
            }
            return false;
        }
        
    }

    internal class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("Create an account");

            Console.Write("Enter UserID: ");
            string userID = Console.ReadLine() ?? "";

            Console.Write("Enter Password: ");
            string password = Console.ReadLine() ?? "";

            UserAccount account = new UserAccount(userID,password);

            Console.WriteLine("\nAccount created!");

            LoginManager loginManager = new LoginManager();

            bool accessGranted = loginManager.Login(account);

            // display whether the users access is granted
            if (accessGranted)
            {
                Console.Write("\nLogin Successful");
            }
            else
            {
                Console.Write("\nAccess Denied. Maximum attempts reached.");
            }

        }
    }
}
