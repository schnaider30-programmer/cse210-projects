using System;
using System.Globalization;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did I learn about myself today?",
        "Did I smile or laugh enough with my friends and my family?",
        "Did I accomplish my goal for today?",
        "Today what did I do to be Happy?"
    };

    public string GetRandomPrompt()
    {
        Random randomText = new Random();

        int index = randomText.Next(_prompts.Count);
        
        return _prompts[index];
    }
}