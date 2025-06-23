using System.Dynamic;
using System;
public class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;


    // Construct FlaggedString: prompt and a boolean.
    public FlaggedString(string prompt, bool hasBeenUsed)
    {
        _prompt = prompt;
        _hasBeenUsed = hasBeenUsed;
    }
    // Return prompt variable.
    public string GetPrompt()
    {
        return _prompt;
    }
    // Make hasBeenUsed true. Setters don't return.
    public void SetHasBeenUsed()
    {
        _hasBeenUsed = true;
    }
    // Get a boolean set as true.
    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }
    // Reset hasBeenUsed
    public void SetHasBeenUsed(bool value)
    {
        _hasBeenUsed = value;
    }

}