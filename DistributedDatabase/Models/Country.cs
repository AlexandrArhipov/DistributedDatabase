using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistributedDatabase.Models
{
    [Table("_countries")]
    public class Country
    {
        [Key]
        [Column("country_id")] public int Id { get; set; }
        [Column("title_ru")] public string TitlesRu { get; set; }
        [Column("title_ua")] public string TitlesUa { get; set; }
        [Column("title_be")] public string TitlesBe { get; set; }
        [Column("title_en")] public string TitlesEn { get; set; }
        [Column("title_es")] public string TitlesEs { get; set; }
        [Column("title_pt")] public string TitlesPt { get; set; }
        [Column("title_de")] public string TitlesDe { get; set; }
        [Column("title_fr")] public string TitlesFr { get; set; }
        [Column("title_it")] public string TitlesIt { get; set; }
        [Column("title_pl")] public string TitlesPl { get; set; }
        [Column("title_ja")] public string TitlesJa { get; set; }
        [Column("title_lt")] public string TitlesLt { get; set; }
        [Column("title_lv")] public string TitlesLv { get; set; }
        [Column("title_cz")] public string TitlesSz { get; set; }

    }
}
