using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackFinal.Models.Domain
{
    public class Response {


        [Key]
        [Column(Order = 1)]
        public Guid FeedbackId { get; set; }

        [ForeignKey("FeedbackId")]
        public FeedbackEntry FeedbackEntry { get; set; }
        [Key]
        [Column(Order = 2)]
        public string QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

        public string ResponseText { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public string HashKey { get; set; }
    }
}
