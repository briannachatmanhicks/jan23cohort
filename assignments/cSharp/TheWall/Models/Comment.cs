#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace TheWall.Models;

public class Comment {
    [Key]
    public int CommentId {get; set;}
    // add more attributes here

    public string CContent {get;set;}

    //! 1 user can make many comments.
    public int UserId{get;set;}
    public User? CAuthor {get;set;}

    //! 1 message can have many comments.
    public int MessageId{get;set;}
    public Message? OriginalM {get;set;}

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
