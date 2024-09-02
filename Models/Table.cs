using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestAdminV2.Models;
[Table("tables")]

public class Table
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("table_number")]
    public string? TableNumber { get; set; }
    [Column("capacity")]
    public int Capacity { get; set; }

}