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
    public class MappingAbsence : EntityTypeConfiguration<Absence>
    {
        public MappingAbsence()
        {
            ToTable("Absence");
            HasKey(a => a.AbsenceId);

            Property(a => a.AbsenceId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Type).IsRequired().HasMaxLength(255);

        }
    }
}
