using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RestAdminV2.Models;

[Table("products")]
public class Product
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("image_url")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} character.")]
    public string? ImageURL { get; set; }

    [Column("name")]
    [MaxLength(50, ErrorMessage = "The field must be at most {1} character.")]
    public string? Name { get; set; }

    [Column("description")]
    [MaxLength(255, ErrorMessage = "The field must be at most {1} character.")]
    public string? Description { get; set; }

    [Column("price")]
    public double Price { get; set; }

}