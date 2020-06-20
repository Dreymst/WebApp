using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTP.Entities
{
    public class Absence
    {
        public int AbsenceId { get; set; }
        public String Type { get; set; }

        public Eleve Eleve { get; set; }
        public int ELeveId { get; set; }
    }
}
