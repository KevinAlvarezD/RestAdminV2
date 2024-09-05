using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace RestAdminV2.Models;
[Table("tables")]

public class Table
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("table_number")]
    [MaxLength(10, ErrorMessage = "The table number must be at most {1} characters.")]
    [Required(ErrorMessage = "The table number is required.")]
    public string TableNumber { get; set; }

    [Column("capacity")]
    [Range(1, int.MaxValue, ErrorMessage = "The capacity must be a positive number greater than zero.")]
    [Required(ErrorMessage = "The capacity is required.")]
    public int Capacity { get; set; }

    [JsonIgnore]
    public virtual ICollection<Ordered> Ordereds { get; set; }

}