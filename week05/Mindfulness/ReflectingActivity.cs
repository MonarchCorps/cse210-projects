using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _rand = new Random();

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description =
            "This activity will help you reflect on times in your life when you have shown strength and resilience.";

        _prompts = new List<string> { "Think of a time when you stood up for someone else.",
                                      "Think of a time when you did something really difficult.",
                                      "Think of a time when you helped someone in need.",
                                      "Think of a time when you did something truly selfless." };

        _questions =
            new List<string> { "Why was this experience meaningful to you?",
                               "Have you ever done anything like this before?",
                               "How did you get started?",
                               "How did you feel when it was complete?",
                               "What made this time different than other times when you were not as successful?",
                               "What is your favorite thing about this experience?",
                               "What could you learn from this experience that applies to other situations?",
                               "What did you learn about yourself through this experience?",
                               "How can you keep this experience in mind in the future?" };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("\nGet ready...");
        ShowSpinner(2);

        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"— {prompt} —");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in:...");
        ShowCountDown(5);

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n> {question} ");
            ShowSpinner(5);
        }

        Console.WriteLine("\nWell done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the Reflecting Activity.");
        ShowSpinner(3);
    }

    private string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        int index = _rand.Next(_questions.Count);
        return _questions[index];
    }
}
