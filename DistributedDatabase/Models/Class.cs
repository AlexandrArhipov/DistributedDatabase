using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedDatabase.Models
{
    [Table("class")]
    public class Class
    {
        [Key]
        [Column("class_id")] public int Id { get; set; }
        [Column("class_name")] public string Name { get; set; }
    }
}
