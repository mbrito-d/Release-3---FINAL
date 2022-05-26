using Kanban_2._0.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kanban_2._0.Mapping
{
    public class SprintsMap : IEntityTypeConfiguration<Sprints>
    {
        public void Configure(EntityTypeBuilder<Sprints> builder)
        {
            builder.HasKey(x => x.Identification);
            builder.Property(x => x.Name).HasMaxLength(58).IsRequired();

            builder.HasMany(x => x.Cartoes).WithOne(x => x.SprintsAssociation);

            builder.ToTable("Sprints");
        }

        
      
    }
}
