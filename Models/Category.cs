using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;
[Table("Category")]
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
}
