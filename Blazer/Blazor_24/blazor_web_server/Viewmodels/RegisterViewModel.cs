using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

public class RegisterViewModel
{
    [Required(ErrorMessage = "UserName cannot be blank!")]
    [StringLength(50, ErrorMessage = "UserName from 6 to 50 charactor!", MinimumLength = 6)]
    public string UserName { get; set;}
    [Required(ErrorMessage = "Password cannot be blank!")]
    public string Password { get; set;}
    [Required(ErrorMessage = "Email cannot be blank!")]
    [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Email is invalid.")]
  
    public string Email { get; set;}
    [Required(ErrorMessage = "FullName cannot be blank!")]
    public string FullName { get; set;}
    public string Gender { get; set;} = "Male";
    public string County { get; set;} = "VN";
}

public class Country
{
    public string ID { get; set;}
    public string Name { get; set;}
}

public static class CountryList
{
    public static List<Country> Values = new List<Country>();
    static CountryList()
    {
        Values.Add(new Country { ID = "VN", Name = "VietNam" });
        Values.Add(new Country { ID = "EN", Name = "England" });
        Values.Add(new Country { ID = "CN", Name = "China" });
    }

    public static void AddCountry (Country newCountry)
    {
        Values.Add(newCountry); 
    }
}