using FeedbackFinal.Models.Domain;

namespace FeedbackFinal.Models
{
    public class SubmissionResult
    {
        public List<FeedbackEntry> FilledResponses { get; set; }
        public int TotalEntries { get; set; }
        public double D1 { get; set; }
        public double D2 { get; set; }
        public double D3 { get; set; }
        public double D4 { get; set; }
        public double D5 { get; set; }
        public double D6 { get; set; } 
        public double D7 { get; set; }
        public double D8 { get; set; }
        public double D9 { get; set; }
        public double D10 { get; set; }
    }
}
