using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the User Login System!");

        string correctUsername = "admin";
        string correctPassword = "password123";

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = ReadPassword();

        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("\nLogin successful! Access granted.");
        }
        else
        {
            Console.WriteLine("\nInvalid username or password. Access denied.");
        }
    }

    static string ReadPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
        }
        while (key.Key != ConsoleKey.Enter);

        return password;
    }
}
