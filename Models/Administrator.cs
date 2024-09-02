using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;

[Table("administrators")]
public class Administrator
{
    [Key]
    [Column("id_administrator")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; }
    [Column("username")]
    [MaxLength(50, ErrorMessage = "The Username field must be at most {1} characters.")]
    public string? UserName { get; set; }
    [Column("password")]
    [MaxLength(255, ErrorMessage = "The Password field must be at most {1} characters.")]
    public string? Password { get; set; }

}    


