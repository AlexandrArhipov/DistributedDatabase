using Microsoft.EntityFrameworkCore;

namespace DistributedDatabase.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Race> Races { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Country> Countries { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(
                "Server = udalovmysql.mysql.database.azure.com; Port = 3306; Database = acount_manager; Uid = AlexUD@udalovmysql; Pwd = Udalovmysql1263;");
        }
    }
}
