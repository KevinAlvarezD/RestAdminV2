using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAdminV2.Models;
[Table ("roles")]
public class Role
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50, ErrorMessage = "The name must be at most {1} characters.")]
    [Required(ErrorMessage = "The name is required.")]
    public string Name { get; set; }
}
