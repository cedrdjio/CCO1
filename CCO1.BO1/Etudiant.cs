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
        public byte[] Matricule { get; set; }
        public int Telephone  {get;set;}
        public string  Emails{get;set;}
        public string Etablissement {get;set;}
         public string Departement { get; set; }
        public byte[] Photo { get; set; }
        public string Sex { get; set; }


        public Etudiant()
        {

        }
        public Etudiant(string Nom)
        {

        }

        public Etudiant(string nom, string prenom, string dateNaissance, string dateAdmission, byte[] matricule, int telephone, string emails, string etablissement, string departement, byte[] photo, string sex) : this(nom)
        {
            Prenom = prenom;
            DateNaissance = dateNaissance;
            DateAdmission = dateAdmission;
            Matricule = matricule;
            Telephone = telephone;
            Emails = emails;
            Etablissement = etablissement;
            Departement = departement;
            Photo = photo;
            Sex = sex;
        }

       
        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Nom.Equals(etudiant.Nom, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }

}


