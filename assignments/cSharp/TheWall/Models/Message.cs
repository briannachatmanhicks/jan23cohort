#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace TheWall.Models;

public class Message {
    [Key]
    public int MessageId {get; set;}
    // add more attributes here

    [Required(ErrorMessage ="Required Field!")]
    public string MContent {get;set;}
    
    //! 1 user can make many messages.
    public int UserId {get;set;}
    public User? MAuthor {get;set;}

    //! 1 message can have many comments.
    public List<Comment> CommentList {get;set;}= new List<Comment> ();

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
