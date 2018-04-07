using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedDatabase.Models
{
    [Table("character")]
    public class Character
    {
        [Key]
        [Column("name")] public string Name { get; set; }
        [Column("sex")] public string Sex { get; set; }
        [Column("skin")] public string Skin { get; set; }
        [Column("height")] public string Height { get; set; }
        [Column("weight")] public string Weight { get; set; }
        [Column("class")] public Class Class { get; set; }
        [Column("race")] public Race Race { get; set; }
    }
}
