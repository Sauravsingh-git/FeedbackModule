using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FeedbackFinal.Models.Domain
{
    public class FeedbackEntry
    {
        [Key]
        public Guid FeedbackId { get; set; }
        public string EnrollmentRollNo { get; set; }

        public string SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public Subject Subject { get; set; }

        public DateTime SubmissionTimestamp { get; set; }

    }

}
