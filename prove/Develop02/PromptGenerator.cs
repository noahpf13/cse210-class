public class PromptGenerator
{
    private List<string> _prompts;
    private Random _rand;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What made me smile today?",
            "Who did I help today?",
            "What did I learn today?",
            "What was challenging today?",
            "What am I grateful for?",
            "When did I see the hand of the Lord?"
        };

        _rand = new Random();
    }
    public string GetRandomPrompt()
    {
        int index = _rand.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}