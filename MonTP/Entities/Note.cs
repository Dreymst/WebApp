using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTP.Entities
{
    public class Note
    {
        public int NoteId { get; set; }
        public string LaNote { get; set; }

        public Eleve Eleve { get; set; }

        public int EleveId { get; set; }
    }
}
