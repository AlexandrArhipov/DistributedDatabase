using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
