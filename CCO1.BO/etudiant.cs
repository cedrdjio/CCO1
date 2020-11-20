using System;

namespace CCO1.BO
{
    public class etudiant
    {
        public string Nom { get; set; }
        public string Prenom  { get; set; }
        public string DateNaissance{ get; set; }
        public string DateAdmission { get; set; }
        public string Matricule{ get; set; }
        public string Departement{ get; set; }


        public etudiant()
        {

        }

        public etudiant(string nom, string prenom,  long dateNaissance, string  dateAdmission, string matricule , string departement )
        {
            Name = name;
            PostalCode = postalCode;
            PhoneNumber = phoneNumber;
            Email = email;
            Logo = logo;
        }

    }
}
