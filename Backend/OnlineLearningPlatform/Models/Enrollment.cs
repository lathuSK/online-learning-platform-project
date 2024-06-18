using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }
        
        [Required]
        public int CourseId { get; set; }
        
        [Required]
        public int UserId { get; set; }

        public Course Course { get; set; } = new Course();
        
        public User User { get; set; } = new User();


    }
}
