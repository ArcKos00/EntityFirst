using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.Entities
{
    public class OfficeConfig : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office");
            builder.HasKey(k => k.OfficeId);

            builder.Property(p => p.OfficeId).HasColumnName("OfficeId").IsRequired(true);
            builder.Property(p => p.Ttitle).HasColumnName("Ttitle").IsRequired(true).HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(p => p.Location).HasColumnName("Location").IsRequired(true).HasColumnType("nvarchar").HasMaxLength(100);

            builder.HasMany(m => m.Employees).WithOne(o => o.Office).HasForeignKey(k => k.OfficeId);
        }
    }
}
