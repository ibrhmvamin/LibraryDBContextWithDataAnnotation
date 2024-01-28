using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask2.Entities
{
    [Table(nameof(GroupsCurators))]
    public class GroupsCurators
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Curator))]
        public int CuratorId { get; set; }

        [Required]
        [ForeignKey(nameof(Group))]

        public int GroupId { get; set; }

        public Curator Curator { get; set; }
        public Group Group { get; set; }
    }
}
