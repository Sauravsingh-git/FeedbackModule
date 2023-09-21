using System.ComponentModel.DataAnnotations;

namespace FeedbackFinal.Models.Domain
{
    public class Subject
    {
        [Key]
        public String SubjectId { get; set; }  

        public String SubjectName { get; set; }
    }
}
