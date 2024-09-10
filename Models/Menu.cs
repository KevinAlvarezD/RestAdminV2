using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace RestAdminV2.Models;

[Table("menu")]
public class Menu
{
    [Key]
    [Column("id")]
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
    [MaxLength(255, ErrorMessage = "The field must be at most {1} characters.")]
    [DataType(DataType.ImageUrl, ErrorMessage = "The field must be a valid URL.")]
    public string ImageURL { get; set; }

    [Column("category")]
    [MaxLength(15, ErrorMessage = "The field must be at most {1} characters.")]
    public string Category { get; set; }



}