using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;

[Table("kitchen_item")]
public class KitchenItem
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("kitchen_id")]
    public int KitchenId { get; set; }

    [ForeignKey("KitchenId")]
    public Kitchen Kitchen { get; set; }

    [Column("product_id")]
    public int ProductId { get; set; }

    [ForeignKey("ProductId")]
    public Product Product { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }
}