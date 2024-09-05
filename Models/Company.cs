using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;
[Table("companys")]
public class Company
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} characters.")]
    [Required(ErrorMessage = "The name is required.")]
    public string Name { get; set; }

    [Column("address")]
    [MaxLength(50, ErrorMessage = "The address field must be at most {1} character.")]
    [MinLength(5, ErrorMessage = "The address field must be at least {1} characters.")]
    [Required(ErrorMessage = "The address is required.")]
    public string Address { get; set; }

    [Column("image_url")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} characters.")]
    [DataType(DataType.ImageUrl, ErrorMessage = "The field must be a valid URL.")]
    [Required(ErrorMessage = "The address is required.")]
    public string ImageURL { get; set; }
}