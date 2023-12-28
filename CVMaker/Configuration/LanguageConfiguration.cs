using CVMaker.Models;
using Microsoft.EntityFrameworkCore;

namespace CVMaker.Configuration
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Language> builder)
        {
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
