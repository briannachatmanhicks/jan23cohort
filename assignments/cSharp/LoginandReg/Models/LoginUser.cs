#pragma warning disable CS8618
// We can disable our warnings safely because we know the framework will assign non-null values 
// when it constructs this class for us.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginandReg.Models;

[NotMapped] // do not add to the database
public class LoginUser
{
    [Required(ErrorMessage ="Required Field!")]
    [EmailAddress]
    [Display(Name = "Email")]
    public string LoginEmail {get;set;}


    [Required(ErrorMessage ="Required Field!")]
    [DataType(DataType.Password)] //the STARS
    [Display(Name ="Password")]
    public string LoginPassword {get;set;}
}