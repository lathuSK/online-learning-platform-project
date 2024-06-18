using System.ComponentModel.DataAnnotations;

namespace OnlineLearningPlatform.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;


    }
}
