using FeedbackFinal.Models.Domain;

namespace FeedbackFinal.Models.Forms
{
    public class SubmissionForm
    {
        public List<SubjectDetails> Subjects { get; set; }
        public string SubjectCode { get; set; }
        public int Year { get; set; }
    }
}
