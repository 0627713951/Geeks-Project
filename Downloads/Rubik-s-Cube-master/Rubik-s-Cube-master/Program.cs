using System;

public class Program
{
    static string[] fruits = new string[10];

    public static void Main(string[] args)
    {
        GetUserInput();
        DisplayFruits();
    }

    public static void GetUserInput()
    {
        Console.WriteLine("Please enter 10 different fruits: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter fruit #{i + 1}: ");
            fruits[i] = Console.ReadLine();
        }
    }

    public static void DisplayFruits()
    {
        Console.WriteLine("\nCollection of Fruits: ");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Fruit #{i + 1}: {fruits[i]}");
        }
    }
}
