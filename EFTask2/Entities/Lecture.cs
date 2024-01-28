using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTask2.Entities
{
    [Table("Lectures")]
    public class Lecture
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column(nameof(LectureDate),TypeName ="date")]
        [Range(typeof(DateTime),"1900-01-01", "{0:yyyy-MM-dd}")]
        public DateTime LectureDate { get; set; }

        [Required]
        [ForeignKey(nameof(Subject))]
        public int SubjectId { get; set; }

        [Required]
        [ForeignKey(nameof(Teacher))]
        public int TeacherId { get; set; }

        public Teacher Teacher { get; set;}
        public Subject Subject { get; set; }
        public ICollection<GroupsLectures> GroupsLectures { get; set; }

    }
}
