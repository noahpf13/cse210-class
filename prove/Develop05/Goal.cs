public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent(ref int totalPoints);

    public virtual bool IsComplete() => false;

    public virtual string GetStatus() => $"[ ] {_name}";

    public abstract string GetStringRepresentation();

    public abstract void LoadFromString(string data);
}
