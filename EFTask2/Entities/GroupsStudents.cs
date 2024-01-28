using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask2.Entities
{
    [Table(nameof(GroupsStudents))]
    public class GroupsStudents
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }

        [Required]
        [ForeignKey(nameof(Group))]

        public int GroupId { get; set; }

        public Student Student { get; set; }
        public Group Group { get; set; }
    }
}
