#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using DateValidator.Models;

namespace DateValidator.Models;

public class User {
    [Required (ErrorMessage="This field is required")]
    public string FirstName{get;set;}

    [Required (ErrorMessage="This field is required")]
    public string LastName{get;set;}

    [FutureDate]
    public DateTime DOB {get;set;}


}


public class FutureDateAttribute : ValidationAttribute{
protected override ValidationResult IsValid(object value, ValidationContext validationContext){
    DateTime CurrentTime = DateTime.Now;
        if (((DateTime)value) > CurrentTime) {  
            Console.WriteLine(CurrentTime);
            return new ValidationResult("The date cannot be in the future");}
        else{
            return ValidationResult.Success; }    
    }
}
