using System;
using System.IO;

namespace Assignment2._3._1
{
    public class UserDetails
    {
        public string Name;
        public int Age;
        public string Address;

        public UserDetails(string Name, int Age, string Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Address = Address;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"\nYour name is {this.Name}");
            Console.WriteLine($"You're {this.Age} years old");
            Console.WriteLine($"You live at {this.Address}");
        }

    }

    public class FileManager
    {
        public void SaveUserDetails(UserDetails user)
        {
            // Gets the path to the current user's Documents folder
            string documentsFolder = Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments);
            // safely combines the Documents folder path with the file name
            string fileName = Path.Combine(documentsFolder,"UserDetails.txt");

            // StreamWriter object connected to text file
            // using ensures that file is closed when its properly closed
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Writing the contents on the file from the passed in objects through user
                writer.WriteLine("User Details");
                writer.WriteLine($"Name: {user.Name}");
                writer.WriteLine($"Age: {user.Age}");
                writer.WriteLine($"Address: {user.Address}");
            }

            Console.WriteLine("\nThe information was saved in the text file.");
            Console.WriteLine($"File Location: {Path.GetFullPath(fileName)}");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Make an object for user details name age and address
            UserDetails user = new UserDetails
                ("Clark Batungbakal", 29, "One Microsoft Way, Redmond, WA 98052");
            
            // Display the user's information
            user.DisplayDetails();

            // Create an object for the save files
            FileManager fileManager = new FileManager();

            // Ensure it that it also saves in the text file
            fileManager.SaveUserDetails(user);

        }
    }
}
