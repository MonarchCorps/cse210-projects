public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract int RecordEvent();

    public virtual string GetDetailsString()
    {
        string checkbox = _isComplete ? "[X]" : "[ ]";
        return $"{checkbox} {_name} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"Goal|{_name}|{_description}|{_points}|{_isComplete}";
    }

    public bool IsComplete()
    {
        return _isComplete;
    }
}
