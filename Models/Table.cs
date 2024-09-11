using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace RestAdminV2.Models;
[Table("tables")]

public class Tables
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(10, ErrorMessage = "The Tables number must be at most {1} characters.")]
    [Required(ErrorMessage = "The Tables number is required.")]
    public string Name { get; set; }

    [Column("state")]
    [MaxLength(15, ErrorMessage = "The Tables number must be at most {1} characters.")]
    [Required(ErrorMessage = "The Tables number is required.")]
    public string State { get; set; }


}