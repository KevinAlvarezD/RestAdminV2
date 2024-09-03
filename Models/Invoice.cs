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
    [Required(ErrorMessage = "The order ID is required..")]
    [Range(1, int.MaxValue, ErrorMessage = "The order ID must be a positive number.")]
    public int IdOrder { get; set; }

    [Column("date_invoice")]
    [DataType(DataType.Date, ErrorMessage = "The invoice date must be in a valid format.")]
    [Range(typeof(DateTime), "1950-01-01", "2100-12-31", ErrorMessage = "The date must be between 01/01/1950 and 31/12/2100.")]
    [Required(ErrorMessage = "The invoice date is required.")]
    public DateTime DateInvoice { get; set; }

    [Column("total")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The total must be a positive number greater than zero.")]
    [DataType(DataType.Currency, ErrorMessage = "The total must be in a valid currency format.")]
    [Display(Name = "Total")]
    public double Total { get; set; }

    [Column("pdf_file")]
    public byte[]? PdfFile { get; set; }  // field for share pdf into Database

    //Foreing Links
    [ForeignKey("IdOrder")]
    public required Ordered Ordered { get; set; }

}