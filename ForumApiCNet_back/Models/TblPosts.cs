namespace ForumApiCNet.Models;

public enum Category
{
    Question,
    Answer,
    Clarification
}

public class TblPosts
{
    public int Id { get; set; }
    public int Thread_Post_Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public Category Category { get; set; }
}
