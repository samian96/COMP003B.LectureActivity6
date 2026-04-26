using System.ComponentModel.DataAnnotations;

namespace COMP003B.LectureActivity6.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]
        [EmailAddress]

        public string Email { get; set; }

        // Collection Navigation Property

        public virtual ICOllection<Enrollment>? Enrollments { get; set; }
    }
}
