using CVMaker.Models;
using Microsoft.EntityFrameworkCore;

namespace CVMaker.Configuration
{
    public class WorkExprienceConfiguration : IEntityTypeConfiguration<WorkExprience>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<WorkExprience> builder)
        {
            builder.Property(p => p.Position).IsRequired();
            builder.Property(p => p.IsCurrent).HasDefaultValue(false);
        }
    }
}
