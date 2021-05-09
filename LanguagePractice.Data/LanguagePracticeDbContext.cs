using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data
{
    public class LanguagePracticeDbContext : DbContext
    {
        public LanguagePracticeDbContext(DbContextOptions<LanguagePracticeDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LanguagePracticeDbContext).Assembly);
        }
    }
}
