using System;

public class Video
{
    //Attributes 
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    //Constructors
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    //Methods
    public void ListComment(Comment comment)//AddComment
    {
        _comments.Add(comment);
    }
    public int CountComments()//GetNumberofComments
    {
        int count = 0;
        count = _comments.Count();
        return count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author} | Length: {_length} seconds");
        Console.WriteLine();
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
    }
}