using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace RestAdminV2.Models;


public enum ProductStatus
{
    Habilitado,
    Deshabilitado
}

[Table("products")]
public class Product
{
    [Key]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} characters.")]
    [Required(ErrorMessage = "The name is required.")]
    public string Name { get; set; }

    [Column("price")]
    [Required(ErrorMessage = "The price is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The price must be a positive number greater than zero.")]
    [DataType(DataType.Currency, ErrorMessage = "The price must be in a valid currency format.")]
    public double Price { get; set; }

    [Column("cost")]
    [Required(ErrorMessage = "The cost is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The cost must be a positive number greater than zero.")]
    [DataType(DataType.Currency, ErrorMessage = "The cost must be in a valid currency format.")]
    public double Cost { get; set; }

    [Column("image_url")]
    [MaxLength(500, ErrorMessage = "The field must be at most {1} characters.")]
    [DataType(DataType.ImageUrl, ErrorMessage = "The field must be a valid URL.")]
    public string ImageURL { get; set; }

    [Column("category_id")]
    public int CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    public Categories Category { get; set; }

    [Column("status")]
    [Required(ErrorMessage = "The status is required.")]
    public ProductStatus Status { get; set; }





}