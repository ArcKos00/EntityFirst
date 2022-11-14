using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.Entities
{
    public class EmployeeProjectConfig : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject");
            builder.HasKey(k => k.EmployeeProjectId);

            builder.Property(p => p.EmployeeProjectId).HasColumnName("EmployeeProjectId").IsRequired(true).ValueGeneratedOnAdd();
            builder.Property(p => p.Rate).HasColumnName("Rate").IsRequired(true).HasColumnType("money");
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").IsRequired(true).HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").IsRequired(true);
            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").IsRequired(true);

            builder.HasOne(o => o.Employees).WithMany(m => m.Projects).HasForeignKey(k => k.EmployeeId);
            builder.HasOne(o => o.Projects).WithMany(m => m.EmployeeProjects).HasForeignKey(k => k.ProjectId);
        }
    }
}
