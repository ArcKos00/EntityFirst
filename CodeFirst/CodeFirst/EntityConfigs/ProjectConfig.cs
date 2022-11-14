using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeFirst.Entities
{
    public class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project");
            builder.HasKey(k => k.ProjectId);

            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").IsRequired(true).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired(true).HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.Budget).HasColumnName("Budget").IsRequired(true).HasColumnType("money");
            builder.Property(p => p.StartedDate).HasColumnName("StartedDate").IsRequired(true).HasColumnType("datetime2").HasMaxLength(7);

            builder.HasMany(m => m.EmployeeProjects).WithOne(o => o.Projects).HasForeignKey(k => k.ProjectId);
        }
    }
}
