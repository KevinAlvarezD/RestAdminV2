using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestAdminV2.Models;
[Table("categorys")]
public class Category
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    
    [Column("name")]
    [MaxLength(50, ErrorMessage = "The name must be at most {1} characters.")]
    [Required(ErrorMessage = "The name is required.")]
    public string Name { get; set; }

    //Foreing Links
    [ForeignKey("IdProduct")]
    public virtual Product Product { get; set; }

    [JsonIgnore]
    [NotMapped]
    public virtual ICollection<Product> Products { get; set; }
}
