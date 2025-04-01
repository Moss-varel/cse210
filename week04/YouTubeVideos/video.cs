namespace YouTubeVideoSystem.Models;
public class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    private List<Comment> Comments { get; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment) => Comments.Add(comment);
    public int GetCommentCount() => Comments.Count;

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Length: {Length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
    }
}
