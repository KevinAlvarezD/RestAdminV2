using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestAdminV2.Models;
[Table("Category")]
public class Category
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    [MaxLength(50, ErrorMessage = "The name must be at most {1} characters.")]
    [Required(ErrorMessage = "The name is required.")]
    public string Name { get; set; }

    [Column("id_product")]
    [Required(ErrorMessage = "The product ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The product ID must be a positive number.")]
    public int IdProduct { get; set; }

    //Foreing Links
    [ForeignKey("IdProduct")]
    public virtual Product Product { get; set; }

    public virtual ICollection<Product> Products { get; set; }
}
