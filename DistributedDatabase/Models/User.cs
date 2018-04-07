using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedDatabase.Models
{
    public class User
    {
        [Key]
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Country { get; set; }
    }
}
