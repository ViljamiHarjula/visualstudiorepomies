using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konsulttiryhmä
{
    class KonsulttiLista
    {

        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Koulutus { get; set; }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi;
        }
    }
}
