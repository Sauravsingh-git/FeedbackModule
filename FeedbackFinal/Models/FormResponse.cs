namespace FeedbackFinal.Models
{
    public class FormResponse
    {
        public string EnrollmentNo {  get; set; }
        public DateTime SubmissionTimestamp {  get; set; }  
        public string QuestionId { get; set; } 
        public string Question {  get; set; }
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string ResponseText { get; set; }

    }
}
