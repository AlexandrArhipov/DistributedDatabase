using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedDatabase.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(
                "Server=localhost;UserId=root;Password=root;database=acount_manager;");
        }
    }
}
