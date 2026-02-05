using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Start Breathing Activity");
            Console.WriteLine("     2. Start Reflecting Activity");
            Console.WriteLine("     3. Start Listing Activity");
            Console.WriteLine("     4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
            case "1":
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;
            case "2":
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
                break;
            case "3":
                ListingActivity listing = new ListingActivity();
                listing.Run();
                break;
            case "4":
                Console.WriteLine("Goodbye!");
                return;
            default:
                Console.WriteLine("Invalid option. Press Enter to continue.");
                Console.ReadLine();
                break;
            }
        }
    }
}
