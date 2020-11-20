using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CCO1.BO
{
    public class Etudiant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string DateNaissance { get; set; }
        public string DateAdmission { get; set; }
        public string Matricule { get; set; }
        public string Departement { get; set; }


        public Etudiant()
        {

        }

        public Etudiant(string nom, string prenom, string dateNaissance, string dateAdmission, string matricule, string departement)
        {
            Nom = nom;
            Prenom = prenom;
           DateNaissance = dateNaissance ;
            DateAdmission = dateAdmission;
            Matricule = matricule;
            Departement = departement; 

    }
        public override bool Equals(object obj)
        {
            return obj is Etudiant  etudiant &&
                   Nom.Equals(etudiant.Nom, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }

}


