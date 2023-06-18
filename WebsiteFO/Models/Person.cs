using System.ComponentModel.DataAnnotations;
namespace WebsiteFO.Models
{
     public class Person
  {
    
    [Required(ErrorMessage = "Firstname is required")]
    [Display(Name = "Firstname")]
    public string Firstname { get; set; }
    

    [Required(ErrorMessage = "Lastname is required")]
    [Display(Name = "Lastname")]
    public string Lastname { get; set; }
    

    [Required(ErrorMessage = "Emailaddress is required")]
    [EmailAddress(ErrorMessage = "Emailaddress is not valid")]
    public string Email { get; set; }


    [Required(ErrorMessage = "Descroption is required")]
    [Display(Name = "Description")]
    public string Description { get; set; }
  }
}