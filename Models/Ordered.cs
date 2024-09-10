
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RestAdminV2.Models;



namespace RestAdminV2.Models;

[Tables("ordereds")]
public class Ordered
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MinLength(5, ErrorMessage = "The Name field must be at least {1} characters.")]
    [MaxLength(90, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string Name { get; set; }

    [Column("id_customer")]
    [Required(ErrorMessage = "The customer ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The customer ID must be a positive number.")]
    public int IdCustomer { get; set; }

    [Column("id_Tables")]
    [Required(ErrorMessage = "The Tables ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The Tables ID must be a positive number.")]
    public int IdTables { get; set; }

    [Column("Users")]
    [Required(ErrorMessage = "The Usersis required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The Users must be a positive number.")]
    public int Users { get; set; }


    //Foreing Links
    [ForeignKey("IdCustomer")]
    public virtual Customer Customer { get; set; }

    [ForeignKey("IdTables")]
    public virtual Tables Tables { get; set; }


    [JsonIgnore]
    public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    
    [JsonIgnore]
    public virtual ICollection<Invoice> Invoices { get; set; }

}
