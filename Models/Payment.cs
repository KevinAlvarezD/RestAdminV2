using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;

[Table("payments")]
public class Payment
{
    [Key]
    [Column("id")]
    public int IdPayment { get; set; }
    
    [Column("id_invoice")]
    public int IdInvoice { get; set; }
    [Column("date_payment")]
    [DataType(DataType.Date)]
    public DateTime DatePayment { get; set; }
    [Column("amount")]
    public double Amount { get; set; }
    [Column("payment_method")]
    public string? PaymentMethod { get; set; }


    //Foreing Links
    [ForeignKey("IdInvoice")]
    public Invoice? Invoice { get; set; }
}