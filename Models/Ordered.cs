
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
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? Name { get; set; }

    [Column("id_customer")]
    public int IdCustomer { get; set; }

    [Column("id_table")]
    public int IdTable { get; set; }

    [Column("employee")]
    public int Employee { get; set; }


    //Foreing Links
    [ForeignKey("IdCustomer")]
    public Customer? Customer { get; set; }

    [ForeignKey("IdTable")]
    public Table? Table { get; set; }
}
