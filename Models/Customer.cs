using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;

[Table("customers")]
public class Customer
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? Name { get; set; }

    [Column("address")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? Address { get; set; }

    [Column("phone_number")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? PhoneNumber { get; set; }

    [Column("email")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? Email { get; set; }

}
