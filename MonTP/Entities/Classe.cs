using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTP.Entities
{
    public class Classe
    {
        public int ClasseId { get; set; }
        public string Nom { get; set; }
        public Collection<Eleve> listeEleve { get; set; }
    }
}
