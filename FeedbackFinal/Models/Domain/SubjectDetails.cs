using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.ComponentModel.DataAnnotations;

namespace FeedbackFinal.Models.Domain
{
	public class SubjectDetails
	{
		[Key]
		public Guid SubjectId { get; set; }
		public string SubjectCode { get; set;  }	
		public string SubjectName { get; set; }
		public DateTime Year { get; set; }
		public string TeacherId { get; set; }
	}
}
