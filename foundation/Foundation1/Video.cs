public class Video
{
    public string _title;
    public string _author;
    public int _length; // In seconds
    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length} seconds");
        Console.WriteLine("Comments:");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
}
