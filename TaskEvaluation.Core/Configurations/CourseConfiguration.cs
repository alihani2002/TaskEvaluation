using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskEvaluation.Web.Models;

namespace TasksEvaluation.Core.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).IsRequired();
        }
    }
}
