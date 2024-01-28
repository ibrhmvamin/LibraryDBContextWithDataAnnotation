using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFTask2.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(nameof(Name), TypeName = "nvarchar(100)")]
        [Required]
        [DefaultValue("None")]
        public string Name { get; set; }

        public ICollection<Lecture> Lecture { get; set; }
    }
}
