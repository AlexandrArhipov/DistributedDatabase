using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DistributedDatabase.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("login")] public string Login { get; set; }
        [Column("password")] public string Password { get; set; }
        [Column("email")] public string Email { get; set; }
        [Column("date_of_birth")] public DateTime DateOfBirth { get; set; }
        [Column("country")] public string Country { get; set; }
    }
}
