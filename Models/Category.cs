using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace RestAdminV2.Models;
[Table("categories")]
public class Categories
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    [MaxLength(50, ErrorMessage = "The name must be at most {1} characters.")]
    [Required(ErrorMessage = "The name is required.")]
    public string Name { get; set; }

}
