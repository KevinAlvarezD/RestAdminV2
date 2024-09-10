using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;


namespace RestAdminV2.Models;


[Table("users")]
public class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MinLength(5, ErrorMessage = "The Name field must be at least {1} characters.")]
    [MaxLength(90, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string Name { get; set; }

    [Column("email")]
    [EmailAddress(ErrorMessage = "The Email field is using an invalid format.")]
    [MinLength(5, ErrorMessage = "The Email field must be at least {1} characters.")]
    [MaxLength(255, ErrorMessage = "The Email field must be at most {1} characters.")]
    public string Email { get; set; }

    [Column("password")]
    [MinLength(5, ErrorMessage = "The password field must be at least {1} characters.")]
    [MaxLength(255, ErrorMessage = "The Password field must be at most {1} characters.")]
    public string Password { get; set; }

    [Column("phone")]
    [MinLength(5, ErrorMessage = "The Telefono field be at least {1} characters.")]
    [MaxLength(25, ErrorMessage = "The Telefono field  be at most {1} characters.")]
    [Phone(ErrorMessage = "the phone format is not valid, you can use this example format if you want => '### ### ## ##'")]
    public string Phone { get; set; }

    [Column("address")]
    [MaxLength(50, ErrorMessage = "The address field must be at most {1} character.")]
    [MinLength(5, ErrorMessage = "The address field must be at least {1} characters.")]
    [Required(ErrorMessage = "The address is required.")]
    public string Address { get; set; }


    [Column("role")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} characters.")]
    [Required(ErrorMessage = "The role is required.")]
    public string Role { get; set; }
}
