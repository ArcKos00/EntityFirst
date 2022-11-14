using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.Entities
{
    public class TitleConfig : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.ToTable("Title");
            builder.HasKey(k => k.TitleId);

            builder.Property(p => p.TitleId).HasColumnName("TitleId").ValueGeneratedOnAdd().IsRequired(true);
            builder.Property(p => p.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(50).IsRequired(true);

            builder.HasMany(m => m.Employees).WithOne(o => o.TitleTab).HasForeignKey(k => k.TitleId);
        }
    }
}
