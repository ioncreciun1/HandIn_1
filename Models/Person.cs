using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace HandIn_1.Models {
public class Person {
    
    public int Id { get; set; }
    
    [NotNull]
    [Required,MinLength(3,ErrorMessage = "Please Enter Adult First Name")]
    public string FirstName { get; set; }
    
    [NotNull]
    [Required,MinLength(1,ErrorMessage = "Please Enter Adult Last Name")]
    public string LastName { get; set; }
    
    [Required]
    [ValidHairColor]
    public string HairColor { get; set; }
    
    [Required]
    [NotNull]
    [ValidEyeColor]
    public string EyeColor { get; set; }

    [NotNull, Range(0, 125)] [Required] 
    public int Age { get; set; }
    
    [Required]
    [NotNull, Range(1, 250)]
    public float Weight { get; set; }
    
    [Required]
    [NotNull, Range(30, 250)]
    public int Height { get; set; }
    
    
    [NotNull]
    [Required]
    public string Sex { get; set; }

    public void Update(Person toUpdate) {
        Age = toUpdate.Age;
        Height = toUpdate.Height;
        HairColor = toUpdate.HairColor;
        Sex = toUpdate.Sex;
        Weight = toUpdate.Weight;
        EyeColor = toUpdate.EyeColor;
        FirstName = toUpdate.FirstName;
        LastName = toUpdate.LastName;
    }

}

public class ValidHairColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"blond", "red", "brown", "black",
            "white", "grey", "blue", "green", "leverpostej"}.ToList();
        if (valid == null || valid.Contains(value.ToString().ToLower())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
    }
}

public class ValidEyeColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"brown", "grey", "green", "blue",
            "amber", "hazel"}.ToList();
        if (valid != null && valid.Contains(value.ToString().ToLower())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
    }
}

}