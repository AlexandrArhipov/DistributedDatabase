using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DistributedDatabase.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> user { get; set; }
        //public DbSet<Character> Characters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;UserId=root;Password=root;database=acount_manager;");
        }
    }
}
