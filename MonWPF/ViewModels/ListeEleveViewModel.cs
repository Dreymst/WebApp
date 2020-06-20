using MonWPF.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonTP;
using MonTP.Entities;

namespace MonWPF.ViewModels
{
    public class ListeEleveViewModel : BaseViewModel
    {

        private ObservableCollection<DetailEleveViewModel> _eleves;
        private DetailEleveViewModel _detail;
        private BusinessLayer.BusinessManager _bm;

        public ListeEleveViewModel()
        {
            _bm = BusinessLayer.BusinessManager.GetInstance();
            _eleves = new ObservableCollection<DetailEleveViewModel>();


            foreach (Eleve eleve in _bm.GetEleves())
            {
                DetailEleveViewModel detailEleveViewModel = new DetailEleveViewModel
                {
                    Nom = eleve.Nom,
                    Prenom = eleve.Prenom,
                    DateDeNaissance = eleve.DateNaissance,
                    Notes = eleve.Notes,
                    Absences = eleve.Absences
                };

                //List<Note> notes = _bm.GetNotesByEleve(eleve.EleveId);
                //detailEleveViewModel.Moyenne = (int)notes.Select(n => n.LaNote).Average();

                detailEleveViewModel.Moyenne = _bm.GetAverageByEleve(eleve.EleveId);
                _eleves.Add(detailEleveViewModel);
            }

            if (_eleves != null && _eleves.Count > 0)
            {
                _detail = _eleves.ElementAt(0);
            }
        }

        public ObservableCollection<DetailEleveViewModel> Eleve
        {
            get { return _eleves; }
            set { _eleves = value; OnPropertyChanged("Eleve"); }
        }

        public DetailEleveViewModel SelectedEleve
        {
            get { return _detail; }
            set { _detail = value; OnPropertyChanged("SelectedEleve"); }
        }
    }
}
