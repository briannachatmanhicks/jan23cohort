#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace CRUDeliciuos.Models;

public class Dish 
{
    [Key]
    public int DishId{get;set;}


    [Required (ErrorMessage ="Field Required")]
    [Display(Name ="Chef's Name")]
    public string ChefName{get;set;}


    [Required (ErrorMessage ="Field Required")]
    public string DishName{get;set;}


    [Required (ErrorMessage ="Field Required")]
    [Display(Name ="# of Calories")]
    public int Calories{get;set;}


    [Required (ErrorMessage ="Field Required")]
    public int Tastiness{get;set;}


    public string? Description{get;set;} 


    public DateTime CreatedAt{get;set;} = DateTime.Now;
    public DateTime UpdatedAt{get;set;} = DateTime.Now;
}