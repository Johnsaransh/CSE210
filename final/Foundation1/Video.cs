public class Video
{
    private string _title;

    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string name, string text)
    {
        Comment c = new Comment(name, text);
        _comments.Add(c);
    }

    public void Display()
    {
        Console.WriteLine($"{_title} by {_author}");
        foreach (Comment theComment in _comments)
        {
            theComment.DisplayCommentInfo();

        }
    }
}



