using MonTP.Entities;
using MonWPF.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonWPF.ViewModels
{
    public class DetailEleveViewModel : BaseViewModel
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateDeNaissance { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<Absence> Absences { get; set; }
        public double Moyenne { get; set; }
    }
}
