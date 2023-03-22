#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models;

public class Chef {
    [Key]
    public int ChefId {get; set;}


    [Required(ErrorMessage ="Required Field!")]
    public string FirstName{get;set;}


    [Required(ErrorMessage ="Required Field!")]
    public string LastName{get;set;}


    [Required(ErrorMessage ="Required Field!")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Display(Name = "Date of Birth")]
    public DateTime DOB{get;set;}

    [Required(ErrorMessage ="Required Field!")]
    [Range(18, int.MaxValue, ErrorMessage = "You must be 18 years of older to be a chef.")]
    public int Age => (int)(DateTime.Now.Subtract(DOB).TotalDays/365);


    //TODO : 1 Chef can create many dishes 
    public List<Dish> DishesCreated {get;set;}= new List<Dish>();

    //TODO: Trying things....

    public Dish? Dish {get;set;}
    
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}

// public class PastDateAttribute : ValidationAttribute{
// protected override ValidationResult IsValid(object value, ValidationContext validationContext){
//     DateTime CurrentTime = DateTime.Now;
//         if (((DateTime)value) > CurrentTime) {  
//             Console.WriteLine(CurrentTime);
//             return new ValidationResult("The date cannot be in the future");}
//         else{
//             return ValidationResult.Success; }    
//     }
// }