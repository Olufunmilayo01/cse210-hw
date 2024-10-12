class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video();
        video1._title = "Learn C# Basics";
        video1._author = "CodeMaster";
        video1._length = 600;

        Comment comment1 = new Comment();
        comment1._name = "John Doe";
        comment1._text = "Great tutorial, thanks!";
        video1.AddComment(comment1);

        Comment comment2 = new Comment();
        comment2._name = "Jane Smith";
        comment2._text = "This helped me understand C#!";
        video1.AddComment(comment2);

       
        Video video2 = new Video();
        video2._title = "Advanced C# Tips";
        video2._author = "DevGuru";
        video2._length = 900;

        Comment comment3 = new Comment();
        comment3._name = "Alice Walker";
        comment3._text = "Really useful tips!";
        video2.AddComment(comment3);

        Comment comment4 = new Comment();
        comment4._name = "Bob Johnson";
        comment4._text = "Clear and concise, thanks!";
        video2.AddComment(comment4);

        
        List<Video> videos = new List<Video> { video1, video2 };

        
        foreach (Video video in videos)
        {
            video.Display();
            Console.WriteLine(); // Blank line for spacing
        }
    }
}