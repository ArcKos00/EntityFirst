using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.Entities
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(k => k.EmployeeId);

            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").ValueGeneratedOnAdd().IsRequired(true);
            builder.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired(true).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.LastName).HasColumnName("LastName").IsRequired(true).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.HiredDate).HasColumnName("HiredDate").IsRequired(true).HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(p => p.DateOfBirdth).HasColumnName("DateOfBirdth").IsRequired(false).HasColumnType("date");
            builder.Property(p => p.TitleId).HasColumnName("TitleId").IsRequired(true);
            builder.Property(p => p.OfficeId).HasColumnName("OfficeId").IsRequired(true);

            builder.HasOne(o => o.Office).WithMany(m => m.Employees).HasForeignKey(k => k.OfficeId);
            builder.HasOne(o => o.TitleTab).WithMany(m => m.Employees).HasForeignKey(k => k.TitleId);
            builder.HasMany(m => m.Projects).WithOne(o => o.Employees).HasForeignKey(k => k.EmployeeId);
        }
    }
}
