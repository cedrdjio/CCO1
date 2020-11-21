using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO1.BO
{
    public class Etablissement
    {
        public string NomEtablissement { get; set; }
        public string Localisation { get; set; }
        public string AddresMail{ get; set; }
        public byte [] Logo { get; set; }
        public int Telephone { get; set; }
        public string BP { get; set; }
        public Etablissement()
        {

        }

        public Etablissement(string nomEtablissement, string localisation, string addresMail, byte[] logo, int telephone, string bP)
        {
            NomEtablissement = nomEtablissement;
            Localisation = localisation;
            AddresMail = addresMail;
            Logo = logo;
            Telephone = telephone;
            BP = bP;
        }
    }
}
