using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kanban_2._0.Models
{
    [Table("Cartoes")]
    public class Cards
    {
        [Column("Id")]
        public int Identification { get; set; }

        [Column("Titulo")]
        public string Title { get; set; }

        [Column("Tempo")]
        public int Time { get; set; }

        [Column("Descricao")]
        public string Description { get; set; }

        [Column("Status")]
        public StatusType? Status { get; set; }

        public enum StatusType
        {
            [Display(Name = "A fazer")]
            Fazer = 0,
            [Display(Name = "Em andamento")]
            Andamento = 1,
            [Display(Name = "Concluído")]
            Finalizado = 3
        }

        [Column("Id - Users")]
        public int UsersIdentification { get; set; }
        public Users UsersAssociation { get; set; }

        [Column("Id - Sprints")]
        public int SprintsIdentification { get; set; }
        public Sprints SprintsAssociation { get; set; }
    }
}
