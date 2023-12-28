using CVMaker.Models;
using Microsoft.EntityFrameworkCore;

namespace CVMaker.Configuration
{
    public class EducationConfiguration:IEntityTypeConfiguration<Education>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Education> builder)
        {
            builder.Property(p => p.Profession).IsRequired();
            builder.Property(p => p.Univercity).IsRequired();
        }
    }
}
