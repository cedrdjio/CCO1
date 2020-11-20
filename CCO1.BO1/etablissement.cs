using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO1.BO1
{
    class etablissement
    {
        public string NomEtablissement { get; set; }
        public string Localisation { get; set; }
        public string AddresMail{ get; set; }
        public string BP { get; set; }
        public etablissement()
        {

        }

        public etablissement(string nomEtablissement, string localisation, string addresMail, string bP)
        {
            NomEtablissement = nomEtablissement;
            Localisation = localisation;
            AddresMail = addresMail;
            BP = bP;
        }

    }
}
