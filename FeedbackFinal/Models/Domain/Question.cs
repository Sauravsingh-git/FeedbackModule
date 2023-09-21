
using System.ComponentModel.DataAnnotations;

namespace FeedbackFinal.Models.Domain
{
    public class Question
    {
        [Key]
        public string QuestionId { get; set; }
        public string QuestionText { get; set; }

    }
}
