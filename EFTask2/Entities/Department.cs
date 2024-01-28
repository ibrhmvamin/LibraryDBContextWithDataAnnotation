using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTask2.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    [Table("Departments")]
    public class Department
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Range(1,5)]
        public int Building { get; set; }

        [Required]
        [DefaultValue(0)]
        [Column(nameof(Financing),TypeName ="money")]
        [Range(0,double.MaxValue)]
        public double Financing { get; set; }

        [Column(nameof(Name),TypeName ="nvarchar(100)")]
        [Required]
        [DefaultValue("None")]
        public string Name { get; set; }

        [Required]
        public int FacultyId { get; set; }

        [ForeignKey(nameof(FacultyId))]
        public Faculty Faculty { get; set; }
        public ICollection<Group> Groups { get; set; }
    }
}
