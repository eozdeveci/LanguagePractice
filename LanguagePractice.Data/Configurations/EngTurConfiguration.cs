using LanguagePractice.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguagePractice.Data.Configurations
{
    class EngTurConfiguration : IEntityTypeConfiguration<EngTur>
    {
        public void Configure(EntityTypeBuilder<EngTur> builder)
        {
            builder.Property(s => s.EnglishWord).HasMaxLength(50);
            builder.Property(s => s.TurkishWord).HasMaxLength(150);
            builder.Property(s => s.RepeatedCount).HasDefaultValue(0);
        }
    }
}
