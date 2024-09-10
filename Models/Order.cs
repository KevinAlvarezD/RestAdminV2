
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RestAdminV2.Models;



namespace RestAdminV2.Models;

[Table("orders")]
public class Order
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

    [ForeignKey("table_id")]
    public virtual Tables Tables { get; set; }


    [JsonIgnore]
    public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Invoice> Invoices { get; set; }

}
