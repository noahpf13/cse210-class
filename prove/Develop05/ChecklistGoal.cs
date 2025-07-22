public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _timesCompleted;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override void RecordEvent(ref int totalPoints)
    {
        _timesCompleted++;
        totalPoints += _points;
        Console.WriteLine($"You earned {_points} points!");

        if (_timesCompleted == _targetCount)
        {
            totalPoints += _bonus;
            Console.WriteLine($"Bonus! You earned an additional {_bonus} points!");
        }
    }

    public override bool IsComplete() => _timesCompleted >= _targetCount;

    public override string GetStatus()
        => $"{(IsComplete() ? "[X]" : "[ ]")} {_name} (Completed {_timesCompleted}/{_targetCount})";

    public override string GetStringRepresentation()
        => $"ChecklistGoal|{_name}|{_description}|{_points}|{_targetCount}|{_timesCompleted}|{_bonus}";

    public override void LoadFromString(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
        _targetCount = int.Parse(parts[4]);
        _timesCompleted = int.Parse(parts[5]);
        _bonus = int.Parse(parts[6]);
    }
}
