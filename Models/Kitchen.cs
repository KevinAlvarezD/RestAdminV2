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

    [Column("order_id")]
    public int OrderId { get; set; }

    [ForeignKey("OrderId")]
    public Order Order { get; set; }

    [JsonIgnore]
    public ICollection<KitchenItem> KitchenItems { get; set; } = new List<KitchenItem>();
}
