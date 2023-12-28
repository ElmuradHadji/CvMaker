using CVMaker.Models;
using Microsoft.EntityFrameworkCore;

namespace CVMaker.Configuration
{
    public class PrimaryDataConfiguration : IEntityTypeConfiguration<PrimaryData>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PrimaryData> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Surname).IsRequired();
        }
    }
}
