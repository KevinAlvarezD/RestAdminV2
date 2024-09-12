using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;


namespace RestAdminV2.Models;


[Table("invoices")]
public class Invoice
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("number")]
    [Required(ErrorMessage = "The order number is required..")]
    [Range(1, int.MaxValue, ErrorMessage = "The order number must be a positive number.")]
    public int Number { get; set; }

    [Column("table_id")]
    [Required(ErrorMessage = "The order ID is required..")]
    [Range(1, int.MaxValue, ErrorMessage = "The order ID must be a positive number.")]
    public int OrderId { get; set; }

    [Column("observations")]
    [MaxLength(155, ErrorMessage = "The observations must be at most {1} characters.")]
    [Required(ErrorMessage = "The observations is required.")]
    public string Observations { get; set; }

    [Column("total")]
    [Range(0.01, double.MaxValue, ErrorMessage = "The total must be a positive number greater than zero.")]
    [DataType(DataType.Currency, ErrorMessage = "The total must be in a valid currency format.")]
    [Display(Name = "Total")]
    public double Total { get; set; }

    [Column("date")]
    [DataType(DataType.Date, ErrorMessage = "The invoice date must be in a valid format.")]
    [Range(typeof(DateTime), "1950-01-01", "2100-12-31", ErrorMessage = "The date must be between 01/01/1950 and 31/12/2100.")]
    [Required(ErrorMessage = "The invoice date is required.")]
    public DateTime DateInvoice { get; set; }


}