using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartNotes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartNotes.Infrastructure.Configurations
{
    public class NoteEntityConfiguration : IEntityTypeConfiguration<NoteEntity>
    {
     
      public void Configure(EntityTypeBuilder<NoteEntity> builder)
        {
            builder.ToTable("Notes")
                .HasKey(x => x.Id);
        }
    }
}
