using Kanban_2._0.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Kanban_2._0.Mapping
{
    public class CardsMap : IEntityTypeConfiguration<Cards>
    {
        public void Configure(EntityTypeBuilder<Cards> builder)
        {
            builder.HasKey(x => x.Identification);
            builder.Property(x => x.Title).HasMaxLength(58).IsRequired();
            builder.Property(x => x.Description).IsRequired();

            builder.HasOne(x => x.SprintsAssociation).WithMany(x => x.Cartoes).HasForeignKey(x => x.SprintsIdentification).IsRequired();
            builder.HasOne(x => x.UsersAssociation).WithMany(x => x.Cartoes).HasForeignKey(x => x.UsersIdentification).IsRequired();

            builder.ToTable("Cartoes");
        }
    }
}
