public class assignment
{
    private string _name;
    private string _topic;

    public assignment(string name, string topic)

    {
        _name = name;
        _topic = topic;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return $"Assignment: {_name}, Topic: {_topic}";
    }
}