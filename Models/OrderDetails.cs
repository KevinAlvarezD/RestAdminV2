using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestAdminV2.Models;

[Table("order_details")]
public class OrderDetails
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("id_ordered")] 
    public int IdOrdered { get; set; }

    [Column("id_product")] 
    public int IdProduct { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("unit_price")]
    public double UnitPrice { get; set; }


    //Foreing Links
    [ForeignKey("IdOrdered")]
    public Ordered? Ordered { get; set; }

    [ForeignKey("IdProduct")]
    public Product? Product { get; set; }

}
