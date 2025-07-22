public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(ref int totalPoints)
    {
        if (!_isComplete)
        {
            _isComplete = true;
            totalPoints += _points;
            Console.WriteLine($"You earned {_points} points!");
        }
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => $"{(_isComplete ? "[X]" : "[ ]")} {_name}";

    public override string GetStringRepresentation()
        => $"SimpleGoal|{_name}|{_description}|{_points}|{_isComplete}";

    public override void LoadFromString(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _isComplete = bool.Parse(parts[4]);
    }
}
