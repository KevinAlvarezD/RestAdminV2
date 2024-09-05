using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;


[Table("employees")]
public class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MinLength(5, ErrorMessage = "The Name field must be at least {1} characters.")]
    [MaxLength(90, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string Name { get; set; }

    [Column("role")]
    [MinLength(5, ErrorMessage = "The role field must be at least {1} characters.")]
    [MaxLength(90, ErrorMessage = "The role field must be at most {1} characters.")]
    public string Role { get; set; }

    [Column("schedule")]
    [DataType(DataType.Date)]
    [Range(typeof(DateTime), "1950-01-01", "2100-12-31", ErrorMessage = "The date must be between 01/01/1950 and 31/12/2100.")]
    public DateTime Schedule { get; set; }

}
