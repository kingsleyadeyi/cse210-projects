using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = prompts.GetRandomPrompt();

                Console.WriteLine("Prompt:");
                Console.WriteLine(prompt);
                Console.WriteLine();
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);

                Console.WriteLine();
                Console.WriteLine("Entry added successfully!");
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully!");
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.Write("Enter the filename: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully!");
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Journal. Goodbye!");
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1-5.");
                Console.WriteLine();
            }
        }
    }
}