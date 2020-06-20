using MonTP.Entities;
using MonTP.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTP
{
    public class MonContexte : DbContext
    {
        public MonContexte() : base("name=MaBDD")
        {
            Database.SetInitializer<MonContexte>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new MappingEleve());
            modelBuilder.Configurations.Add(new MappingClasse());
            modelBuilder.Configurations.Add(new MappingNote());
            modelBuilder.Configurations.Add(new MappingAbsence());
        }

        public DbSet<Absence> Absence { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Eleve> Eleves { get; set; }
        public DbSet<Note> Note { get; set; }
    }
}
