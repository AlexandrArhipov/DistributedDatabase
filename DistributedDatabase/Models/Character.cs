using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistributedDatabase.Models
{
    [Table("character")]
    public class Character
    {
        [Key]
        [Column("name")] public string Name { get; set; }
        [Column("sex")] public string Sex { get; set; }
        [Column("skin")] public string Skin { get; set; }
        [Column("height")] public int Height { get; set; }
        [Column("weight")] public int Weight { get; set; }
        [Column("class")] public int ClassId { get; set; }
        [Column("race")] public int RaceId { get; set; }
    }
}
