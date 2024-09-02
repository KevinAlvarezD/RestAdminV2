using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdmin.Models;


[Table("employees")]
public class Employee
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    [MaxLength(255, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string? Name { get; set; }
    [Column("role")]
    [MaxLength(255, ErrorMessage = "The Role field must be at most {1} characters.")]
    public string? Role { get; set; }
    [Column("schedule")]
    [DataType(DataType.Date)]
    public DateTime Schedule { get; set;}

}
