using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;


[Table("invoices")]
public class Invoice
{
    [Key]
    [Column("id_invoice")]
    public int IdInvoice { get; set; }

    [Column("id_order")]
    public int IdOrder { get; set; }

    [Column("date_invoice")]
    [DataType(DataType.Date)]
    public DateTime DateInvoice { get; set; }

    [Column("total")]
    public double Total { get; set; }

    //Foreing Links
    [ForeignKey("IdOrder")]
    public Ordered Ordered { get; set; }

}