using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace RestAdminV2.Models;

[Table("kitchen")]
public class Kitchen
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("table_id")]
    [Required(ErrorMessage = "The order ID is required..")]
    [Range(1, int.MaxValue, ErrorMessage = "The order ID must be a positive number.")]
    public int OrderId { get; set; }

    [Column("items")]
    public ICollection<Menu> Items { get; set; }

    [Column("observations")]
    [MaxLength(155, ErrorMessage = "The observations must be at most {1} characters.")]
    [Required(ErrorMessage = "The observations is required.")]
    public string Observations { get; set; }

}
