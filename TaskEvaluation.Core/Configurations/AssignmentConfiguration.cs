using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskEvaluation.Web.Models;

namespace TasksEvaluation.Core.Configurations
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Title).IsRequired();

            builder.HasOne(a => a.Solution)
               .WithOne(s => s.Assignment)
               .HasForeignKey<Solution>(s => s.AssignmentId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(a => a.Group)
                   .WithMany(g => g.Assignments)
                   .HasForeignKey(a => a.GroupId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
