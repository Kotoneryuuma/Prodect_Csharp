using System.ComponentModel.DataAnnotations;

namespace product.Models
{
  public class LoginForm
  {
    [Required]
    [EmailAddress]
    public string Email {get;set;}

    [Required]
    [DataType(DataType.Password)]
    public string Password {get;set;}
  }
}