using Microsoft.EntityFrameworkCore;
using SmartNotes.Domain.Models;

namespace SmartNotes.Data.Context
{
    public class SmartNotesContext : DbContext
    {
        public DbSet<Note> Note { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=SmartNotes;user=root;password=ramones");
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
