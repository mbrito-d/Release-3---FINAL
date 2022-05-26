using Kanban_2._0.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Kanban_2._0.Models
{
    public class KanbanConnection : DbContext
    {
        public KanbanConnection(DbContextOptions<KanbanConnection> options)
            : base(options)
        {
        }

        public DbSet<Cards> Cards { get; set; }
        public DbSet<Users> Sprints { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Json", false, true)
                .Build();

            optionsBuilder.UseNpgsql(configuration.GetConnectionString("DBKanban"));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UsersMap());
            builder.ApplyConfiguration(new SprintsMap());
            builder.ApplyConfiguration(new CardsMap());
        }
    }

}
