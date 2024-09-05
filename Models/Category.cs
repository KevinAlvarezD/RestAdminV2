using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Models;
[Table("Category")]
public class Category
{
    
    public int Id { get; set; }
    public string Name { get; set; }

    [ForeignKey("IdProduct")]
    public virtual Product Product { get; set; }
}
