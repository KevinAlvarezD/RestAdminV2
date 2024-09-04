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
    [MinLength(5, ErrorMessage = "The Name field must be at least {1} characters.")]
    [MaxLength(90, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string Name { get; set; }

    [Column("username")]
    [MinLength(5, ErrorMessage = "The username field must be at least {1} characters.")]
    [MaxLength(50, ErrorMessage = "The Username field must be at most {1} characters.")]
    public string UserName { get; set; }

    [Column("password")]
    [MinLength(5, ErrorMessage = "The password field must be at least {1} characters.")]
    [MaxLength(255, ErrorMessage = "The Password field must be at most {1} characters.")]
    public string Password { get; set; }

}


