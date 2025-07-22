public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent(ref int totalPoints)
    {
        totalPoints += _points;
        Console.WriteLine($"You earned {_points} points!");
    }

    public override string GetStatus() => $"[∞] {_name}";

    public override string GetStringRepresentation()
        => $"EternalGoal|{_name}|{_description}|{_points}";

    public override void LoadFromString(string data)
    {
        var parts = data.Split('|');
        _name = parts[1];
        _description = parts[2];
        _points = int.Parse(parts[3]);
    }
}
