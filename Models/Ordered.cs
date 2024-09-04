
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RestAdmin.Models;


namespace RestAdminV2.Models;

[Table("ordereds")]
public class Ordered
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MinLength(5, ErrorMessage = "The Name field must be at least {1} characters.")]
    [MaxLength(90, ErrorMessage = "The Name field must be at most {1} characters.")]
    public string? Name { get; set; }

    [Column("id_customer")]
    [Required(ErrorMessage = "The customer ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The customer ID must be a positive number.")]
    public int IdCustomer { get; set; }

    [Column("id_table")]
    [Required(ErrorMessage = "The table ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The table ID must be a positive number.")]
    public int IdTable { get; set; }

    [Column("employee")]
    [Required(ErrorMessage = "The employeeis required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The employee must be a positive number.")]
    public int Employee { get; set; }


    //Foreing Links
    [ForeignKey("IdCustomer")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("IdTable")]
    public virtual Table? Table { get; set; }
}
