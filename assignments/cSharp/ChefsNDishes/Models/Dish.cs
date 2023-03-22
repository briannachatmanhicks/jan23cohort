#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;

public class Dish {
    [Key]
    public int DishId {get; set;}


    [Required(ErrorMessage ="Required Field!")]
    public string DishName{get;set;}


    [Required(ErrorMessage ="Required Field!")]
    [Range(1, int.MaxValue, ErrorMessage ="The value must be greater than 0.")]
    public int Calories {get;set;}


    [Required(ErrorMessage ="Required Field!")]
    [Range(1,5, ErrorMessage ="The value must be between 1 and 5")]
    public int Tastiness {get;set;}

    [Required(ErrorMessage ="Required Field!")]
    public string ChefName {get;set;}


    //TODO : HERE I AM ALLOWING ACCESS TO THE CHEF MODEL THROUGH THE DISH
    public int ChefId {get;set;}
    public Chef? Chef {get;set;}

    List<Chef> ExistingChefs{get;set;} = new List<Chef>();
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}