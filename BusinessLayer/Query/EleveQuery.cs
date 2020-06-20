using MonTP;
using MonTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Query
{
    public class EleveQuery
    {
        private MonContexte _contexte;

        /// <param name="contexte">MonContexte</param>
        public EleveQuery(MonContexte contexte)
        {
            _contexte = contexte;
        }

        public List<Eleve> GetAll()
        {
            return _contexte.Eleves.ToList();
        }

        public Eleve GetEleveById(int id)
        {
            return _contexte.Eleves.FirstOrDefault(e => e.EleveId == id);
        }
    }
}
