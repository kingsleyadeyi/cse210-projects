using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int duration)
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list things you are grateful for.",
            duration)
    {
        _count = 0;
        _prompts = new List<string>();
    }

    public void Run()
    {
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public List<string> GetListFromUser()
    {
        return new List<string>();
    }
}