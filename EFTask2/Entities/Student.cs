using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask2.Entities
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(nameof(Name), TypeName = "nvarchar(max)")]
        [Required]
        [DefaultValue("None")]
        public string Name { get; set; }

        [Required]
        [Range(0, 5)]
        public int Rating { get; set; }

        [Column(nameof(Surname), TypeName = "nvarchar(max)")]
        [Required]
        [DefaultValue("None")]
        public string Surname { get; set; }

        public ICollection<GroupsStudents> GroupsStudents { get; set; }

    }
}
