using BusinessLayer.Query;
using MonTP;
using MonTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessManager
    {
        #region Strucure / Singleton
        private static BusinessManager _instance;

        private MonContexte _monContexte;

        private BusinessManager()
        {
            _monContexte = new MonContexte();
        }


        public static BusinessManager GetInstance()
        {
            if (_instance != null)
            {
                return _instance;
            }

            _instance = new BusinessManager();
            return _instance;
        }
        #endregion

        #region eleve
        public List<Eleve> GetEleves()
        {
             EleveQuery query = new EleveQuery(_monContexte);
             var result = query.GetAll();
             return result;

        }

        public List<Note> GetNotesByEleve(int eleveId)
        {
            NoteQuery query = new NoteQuery(_monContexte);
            return query.GetAll().ToList();
        }

        public double GetAverageByEleve(int etudiantId)
        {
            //List<Note> notes = _bm.GetNotesByEleve(eleve.EleveId);
            //detailEleveViewModel.Moyenne = (int)notes.Select(n => n.LaNote).Average();    

            return 10.3;
        }
        #endregion

    }
}
