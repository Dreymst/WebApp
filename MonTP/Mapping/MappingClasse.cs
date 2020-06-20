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
    public class MappingClasse : EntityTypeConfiguration<Classe>
    {
        public MappingClasse()
        {
            ToTable("Classe");
            HasKey(c => c.ClasseId);

            Property(e => e.ClasseId).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(e => e.Nom).IsRequired().HasMaxLength(255);


        }
    }
}
