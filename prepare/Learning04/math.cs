public class math : assignment
{
    private string _textbook;
    private string _problems; 

    public math(string name, string textbook, string problems) : base(name, "Math")
    {
      _textbook = textbook;
      _problems = problems;
    }

    public string GetTextbook()
    {
        return _textbook;
    }

    public string GetHomeworkList()
    {
        return $"Assignment: {GetName()}, Textbook: {_textbook}, Problems: {_problems}";
    }
}