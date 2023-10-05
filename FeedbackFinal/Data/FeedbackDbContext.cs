using Microsoft.EntityFrameworkCore;
using FeedbackFinal.Models.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace FeedbackFinal.Data
{
    public class FeedbackDbContext : DbContext
    {

        public FeedbackDbContext(DbContextOptions options) : base( options)
        {}

        public DbSet<FeedbackEntry> FeedbackEntry { get; set; }

        public DbSet<Response> ResponseEntry { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<SubjectDetails> SubjectDetails { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<SubjectDetails>().HasData(
                new SubjectDetails { SubjectId = Guid.NewGuid(), SubjectCode = "MCA-101", SubjectName = "Data Structures", Year = new DateTime(2023, 1, 1), TeacherId="Parul" },
                new SubjectDetails {  SubjectId = Guid.NewGuid(), SubjectCode = "MCA-223", SubjectName = "Cloud Computing", Year = new DateTime(2023, 1, 1), TeacherId= "Parul"},
                new SubjectDetails {  SubjectId = Guid.NewGuid(), SubjectCode = "MCA-105", SubjectName= "Operating System With Linux", Year = new DateTime(2022, 1, 1), TeacherId = "Sunil"},
                new SubjectDetails {  SubjectId = Guid.NewGuid(), SubjectCode = "MCA-233", SubjectName = "Multimedia", Year = new DateTime(2023, 1, 1), TeacherId="Sunil"},
                new SubjectDetails { SubjectId = Guid.NewGuid(), SubjectCode = "MCA-103", SubjectName = "Computer Networks", Year = new DateTime(2023, 1, 1), TeacherId="Manish" }
                );
		}
	}
}
