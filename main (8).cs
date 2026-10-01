using System;

class Logika

{
    public static void Main(string[] args);
    {
        Console.Write("Enter your age : ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Password : ");
        string password = Console.ReadLine();
        
        bool isAdult = age > 18 ;
        bool isPasswordValid = password = "admin";
        
        if (isAdult && isPasswordValid)
        {
            Console.WriteLine("Welcome To The CLub");
        }
        else
        {
            Console.WriteLine("Sorry Bro..., Try Again Please...");
        }
    }
}