using LanguagePractice.Core.Entities;
using LanguagePractice.Core.Entities.Concrete;
using LanguagePractice.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace LanguagePractice.DataAccess.Concrete.EntityFramework
{
    public class LanguagePracticeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=admin;Server=localhost;Port=5432;Database=LanguagePractice;Integrated Security=true;Pooling=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<TurWord> TurDictionary { get; set; }
        public DbSet<EngWord> EngDictionary { get; set; }
        public DbSet<EngTurRelation> EngTurRelation { get; set; }
        public DbSet<UserWordList> UserWordList { get; set; }
    }
}
