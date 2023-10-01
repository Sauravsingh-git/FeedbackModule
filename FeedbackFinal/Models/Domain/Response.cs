using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackFinal.Models.Domain
{
    public class Response {


        [Key]
        public Guid FeedbackId { get; set; }

        [ForeignKey("FeedbackId")]
        public FeedbackEntry FeedbackEntry { get; set; }



        public string ResponseTextA1 { get; set; }
        public string ResponseTextA2 { get; set; }
        public string ResponseTextA3 { get; set; }
        public string ResponseTextB1 { get; set; }
		public string ResponseTextB2 { get; set; }
		public string ResponseTextB3 { get; set; }
		public string ResponseTextB4 { get; set; }
		public string ResponseTextB5 { get; set; }
		public string ResponseTextB6 { get; set; }
        public string ResponseTextC1 { get; set; }
		public string ResponseTextC2 { get; set; }

        public string ResponseTextC3 { get; set; }
        public string ResponseTextC4 { get; set; }
        public string ResponseTextC5 { get; set; }
        public string ResponseTextD1 { get; set; }
		public string ResponseTextD2 { get; set; }
		public string ResponseTextD3 { get; set; }
		public string ResponseTextD4 { get; set; }
		public string ResponseTextD5 { get; set; }
		public string ResponseTextD6 { get; set; }
		public string ResponseTextD7 { get; set; }
		public string ResponseTextD8 { get; set; }
		public string ResponseTextD9 { get; set; }
		public string ResponseTextD10 { get; set; }
        public string ResponseTextE1 { get; set; }
        public string ResponseTextF1 { get; set; }
        public string ResponseTextG1 { get; set; }
        public string ResponseTextH1 { get; set; }
        public string ResponseTextI1 { get; set; }
		public string ResponseTextI2 { get; set; }
		public string ResponseTextI3 { get; set; }
		public string ResponseTextI4 { get; set; }
		public string ResponseTextI5 { get; set; }
        public string ResponseTextJ1 { get; set; }
		public string ResponseTextJ2 { get; set; }
		public string ResponseTextJ3 { get; set; }
		public string ResponseTextJ4 { get; set; }
		public string ResponseTextJ5 { get; set; }
        public string ResponsetextK1 { get; set; }

    }
}
