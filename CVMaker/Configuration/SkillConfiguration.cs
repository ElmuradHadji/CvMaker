using CVMaker.Models;
using Microsoft.EntityFrameworkCore;

namespace CVMaker.Configuration
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Skill> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            
        }
    }
}
