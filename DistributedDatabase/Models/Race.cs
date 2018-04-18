using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistributedDatabase.Models
{
    [Table("race")]
    public class Race
    {
        [Key]
        [Column("race_id")] public int Id { get; set; }
        [Column("race_name")] public string Name { get; set; }
    }
}
