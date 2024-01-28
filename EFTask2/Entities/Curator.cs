using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTask2.Entities
{
    [Table("Curators")]
    public class Curator
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(nameof(Name),TypeName = "nvarchar(max)")]
        [DefaultValue("None")]
        public string Name { get; set; }

        [Required]
        [Column(nameof(Name), TypeName = "nvarchar(max)")]
        [DefaultValue("None")]
        public string Surname { get; set; }

        public ICollection<GroupsCurators> GroupsCurators { get; set; }
    }
}
