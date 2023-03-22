#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyWValidation.Models;

namespace DojoSurveyWValidation.Models;

public class Survey
{
    [Required (ErrorMessage="This field is required")]
    [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
    public string Name { get; set; }


    [Required (ErrorMessage="This field is required")]
    public string Location { get; set; }


    [Required (ErrorMessage="This field is required")]
    public string Language { get; set; }


    [MinLength(20, ErrorMessage="Comments must have at least 20 characters")]
    public string? Comments { get; set; }
}