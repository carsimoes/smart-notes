using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SmartNotes.Domain.NoteFeature.Entities;

namespace SmartNotes.Data.Context
{
    public class SmartNotesContext : DbContext
    {
        public DbSet<Note> Note { get; set; }

        IConfiguration appConfig;

        public SmartNotesContext(IConfiguration config)
        {
            appConfig = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var cn = appConfig.GetConnectionString("SmartNotesDb");
            optionsBuilder.UseMySQL(cn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Note>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Content).IsRequired();
                entity.Property(e => e.CreatedDate).IsRequired();
            });
        }
    }
}
