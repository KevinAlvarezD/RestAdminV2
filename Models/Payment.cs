using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace RestAdminV2.Models;

[Table("payments")]
public class Payment
{
    [Key]
    [Column("id")]
    public int IdPayment { get; set; }

    [Column("id_invoice")]
    [Required(ErrorMessage = "The invoice ID is required.")]
    [Range(1, int.MaxValue, ErrorMessage = "The invoice ID must be a positive number.")]
    public int IdInvoice { get; set; }

    [Column("date_payment")]
    [DataType(DataType.Date, ErrorMessage = "The payment date must be in a valid date format.")]
    [Display(Name = "Payment Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required(ErrorMessage = "The payment date is required.")]
    public DateOnly DatePayment { get; set; }

    [Column("amount")]
    [Required(ErrorMessage = "The amount is required.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The amount must be a positive number greater than zero.")]
    [DataType(DataType.Currency, ErrorMessage = "The amount must be in a valid currency format.")]
    public double Amount { get; set; }

    [Column("payment_method")]
    [StringLength(50, ErrorMessage = "The payment method cannot exceed 50 characters.")]
    [Required(ErrorMessage = "The payment method is required.")]
    [Display(Name = "Payment Method")]
    public required string PaymentMethod { get; set; }


    //Foreing Links
    [ForeignKey("IdInvoice")]
    public virtual Invoice Invoice { get; set; }
}