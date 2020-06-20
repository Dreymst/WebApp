using MonTP;
using MonTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Query
{
    class NoteQuery
    {
        private MonContexte _contexte;

        /// <param name="contexte">MonContexte</param>
        public NoteQuery(MonContexte contexte)
        {
            _contexte = contexte;
        }

        public IQueryable<Note> GetAll()
        {
            return _contexte.Note;
        }

        public IQueryable<Note> GetByID(int id)
        {
            return _contexte.Note.Where(e => e.EleveId == id);
        }


    }
}
