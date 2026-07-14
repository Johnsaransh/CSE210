public class writing : assignment
{
    private string _title;

    public writing(string name, string title) : base(name, "Writing")
    {
      _title = title;
    }
  

    public string GetWritingInformation()
    {
        return $"Assignment: {GetName()}, Title: {_title}";
    }
}