using MonTP.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTP.Mapping
{
    public class MappingNote : EntityTypeConfiguration<Note>
    {
        public MappingNote()
        {
            ToTable("Note");
            HasKey(n => n.NoteId);

            Property(n => n.NoteId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(n => n.LaNote).IsRequired().HasMaxLength(255);

            Property(n => n.EleveId).IsRequired();

        }

    }
}
