using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;
    private Random _rand = new Random();

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as " +
                       "many things as you can in a certain area.";

        _prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?",
                                      "Who are people that you have helped this week?",
                                      "When have you felt the Holy Ghost this month?",
                                      "Who are some of your personal heroes?" };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("You have 5 seconds to think...");
        ShowCountDown(5);

        List<string> items = GetListFromUser();
        Console.WriteLine($"\nYou listed {items.Count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Item: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }
        return items;
    }
}
