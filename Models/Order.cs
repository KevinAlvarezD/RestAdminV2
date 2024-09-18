
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RestAdminV2.Models;



namespace RestAdminV2.Models
{

    public enum OrderStatus
    {
        Cocinando,
        Ocupado,
        PorFacturar,
        Finalizado,
        Cancelado
    }

    [Table("orders")]
    public class Order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("status")]
        [Required(ErrorMessage = "The status is required.")]
        public OrderStatus Status { get; set; }

        [Column("tables_id")]
        public int? TablesId { get; set; }

        [ForeignKey("TablesId")]
        public Tables? Tables { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

        [Column("observations")]
        [MaxLength(155, ErrorMessage = "The observations must be at most {1} characters.")]
        [Required(ErrorMessage = "The observations is required.")]
        public string Observations { get; set; }

        




    }
}
