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

        // ovverriding the OnModelCreating method since entityCore does not support 
        // creating composite key and can be created using 'HasKey' in OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Response>()
            .HasKey(p => new { p.FeedbackId, p.QuestionId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
