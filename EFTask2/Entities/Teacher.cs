using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTask2.Entities
{
    [Table("Teachers")]
    public class Teacher
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(nameof(IsProfessor),TypeName ="bit")]
        [DefaultValue(false)]
        public bool IsProfessor { get; set; }

        [Column(nameof(Name), TypeName = "nvarchar(max)")]
        [Required]
        [DefaultValue("None")]
        public string Name { get; set; }

        [Required]
        [Column(nameof(Salary), TypeName = "money")]
        [Range(1,double.MaxValue)]
        public double Salary { get; set; }

        [Column(nameof(Surname), TypeName = "nvarchar(max)")]
        [Required]
        [DefaultValue("None")]
        public string Surname { get; set; }
        public ICollection<Lecture> Lecture { get; set; }

    }
}
