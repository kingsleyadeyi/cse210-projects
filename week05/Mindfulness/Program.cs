using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    StartBreathingActivity();
                    break;

                case "2":
                    StartReflectingActivity();
                    break;

                case "3":
                    StartListingActivity();
                    break;

                case "4":
                    running = false;
                    Console.WriteLine();
                    Console.WriteLine("Thank you for using the Mindfulness Program.");
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }
    }

    static int GetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");

        int duration;

        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.Write("Please enter a positive number of seconds: ");
        }

        return duration;
    }

    static void StartBreathingActivity()
    {
        Console.Clear();

        string name = "Breathing Activity";

        string description =
            "This activity will help you relax by walking you through breathing " +
            "in and out slowly. Clear your mind and focus on your breathing.";

        int duration = GetDuration();

        BreathingActivity activity =
            new BreathingActivity(name, description, duration);

        activity.Run();

        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    static void StartReflectingActivity()
    {
        Console.Clear();

        string name = "Reflecting Activity";

        string description =
            "This activity will help you reflect on times in your life when " +
            "you have shown strength and resilience. This will help you " +
            "recognize the power you have and how you can use it in other " +
            "aspects of your life.";

        int duration = GetDuration();

        ReflectingActivity activity =
            new ReflectingActivity(name, description, duration);

        activity.Run();

        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }

    static void StartListingActivity()
    {
        Console.Clear();

        string name = "Listing Activity";

        string description =
            "This activity will help you reflect on the good things in your " +
            "life by having you list as many things as you can in a certain area.";

        int duration = GetDuration();

        ListingActivity activity =
            new ListingActivity(name, description, duration);

        activity.Run();

        Console.WriteLine();
        Console.WriteLine("Press Enter to return to the menu...");
        Console.ReadLine();
    }
}