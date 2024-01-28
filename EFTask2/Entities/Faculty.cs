using Microsoft.EntityFrameworkCore;
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
    [Table("Faculties")]
    [Index(nameof(Name), IsUnique = true)]
    public class Faculty
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(nameof(Name), TypeName = "nvarchar(100)")]
        [Required]
        [DefaultValue("None")]
        public string Name { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}
