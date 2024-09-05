using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestAdminV2.Models;

[Table("customers")]
public class Customer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MinLength(5, ErrorMessage = "The Name field must be at least {1} characters.")]
    [MaxLength(90, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string Name { get; set; }

    [Column("address")]
    [MinLength(5, ErrorMessage = "The address field must be at least {1} characters.")]
    [MaxLength(50, ErrorMessage = "The address field must be at most {1} character.")]
    public string Address { get; set; }

    [Column("phone_number")]
    [MinLength(5, ErrorMessage = "The Telefono field be at least {1} characters.")]
    [MaxLength(25, ErrorMessage = "The Telefono field  be at most {1} characters.")]
    [Phone(ErrorMessage = "the phone format is not valid, you can use this example format if you want => '### ### ## ##'")]
    public string PhoneNumber { get; set; }

    [Column("email")]
    [EmailAddress(ErrorMessage = "The Email field is using an invalid format.")]
    [MinLength(5, ErrorMessage = "The Email field must be at least {1} characters.")]
    [MaxLength(255, ErrorMessage = "The Email field must be at most {1} characters.")]
    public string Email { get; set; }

    [JsonIgnore]
    public virtual ICollection<Ordered> Ordereds { get; set; }
}
