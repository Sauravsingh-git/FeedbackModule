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


    }
}
