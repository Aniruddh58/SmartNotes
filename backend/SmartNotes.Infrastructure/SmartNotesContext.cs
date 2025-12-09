using Microsoft.EntityFrameworkCore;
using SmartNotes.Domain.Entities;

namespace SmartNotes.Infrastructure
{
    public class SmartNotesContext : DbContext
    {
        private DbSet<NoteEntity> Notes { get; set; }
        public SmartNotesContext(DbContextOptions<SmartNotesContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(SmartNotesContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
