using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanban_2._0.Models
{
    [Table("Sprints")]
    public class Sprints
    {
        [Column("Nome")]
        public string Name { get; set; }

        [Column("Id")]
        public int Identification { get; set; }

        public ICollection<Cards> Cartoes { get; set; }
    }
}
