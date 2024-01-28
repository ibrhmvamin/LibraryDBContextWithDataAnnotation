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
    [Table("Groups")]
    [Index(nameof(Name), IsUnique = true)]

    public class Group
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(nameof(Name), TypeName = "nvarchar(100)")]
        [Required]
        [DefaultValue("None")]
        public string Name { get; set; }

        [Required]
        [Range(1,5)]
        public int Year { get; set; }

        [Required]

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }
        
        public Department Department { get; set; }

        public ICollection<GroupsCurators> GroupsCurators { get; set; }

        public ICollection<GroupsLectures> GroupsLectures { get; set; }

        public ICollection<GroupsStudents> GroupsStudents { get; set; }


    }
}
