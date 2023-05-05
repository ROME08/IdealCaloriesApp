using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ideal_CaloriesApp.Pages;

public class IndexModel:PageModel
{
    [BindProperty]
    public double Weight {get;set;}
    [BindProperty]
    public double Height {get;set;}
     

    [BindProperty]
    public string WeightUnit {get;set;}
    public List<SelectListItem>WeightUnits{get;} = new List<SelectListItem>
    {
        new SelectListItem { Value = "lbs", Text = "lbs" },
        new SelectListItem { Value = "kg", Text = "kg" }
    };
    [BindProperty]
    public string HeightUnit { get; set; }
    public List<SelectListItem> HeightUnits { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "in", Text = "in" },
        new SelectListItem { Value = "cm", Text = "cm" }
    };

    [BindProperty]
    public int Age { get; set; }

    [BindProperty]
    public string Gender { get; set; }
    public List<SelectListItem> Genders { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "m", Text = "Male" },
        new SelectListItem { Value = "f", Text = "Female" }
    };

    [BindProperty]
    public string ActivityLevel { get; set; }
    public List<SelectListItem> ActivityLevels { get; } = new List<SelectListItem>
    {
        new SelectListItem { Value = "1", Text = "Sedentary (little or no exercise): BMR x 1.2" },
        new SelectListItem { Value = "2", Text = "Lightly active (light exercise or sports 1-3 days a week): BMR x 1.375" },
        new SelectListItem { Value = "3", Text = "Moderately active (moderate exercise or sports 3-5 days a week): BMR x 1.55" },
        new SelectListItem { Value = "4", Text = "Very active (hard exercise or sports 6-7 days a week): BMR x 1.725" },
        new SelectListItem { Value = "5", Text = "Extra active (very hard exercise or sports, physical job or training twice a day): BMR x 1.9 " }
    };

    public IndexModel()
    {
        Weight = 90;
        WeightUnit = "kg";
        Height = 170;
        HeightUnit = "cm";
        Age = 30;
        Gender = "m";
        ActivityLevel = "3";

    }
     // This is the default GET request handler for the page
    public void OnGet()
    {
        ViewData["Message"] = "Hello, world!";
    }

    public void OnPost()
    {
        Console.WriteLine($"Weight: {Weight} {WeightUnit} Height: {Height} {HeightUnit} Age: {Age} Gender: {Gender} ActivityLevel: {ActivityLevel}");
    }

}