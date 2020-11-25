using CCO1.DAL;
using CCO1.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO1.BLL
{
    public class EtudiantBLO
    {
        EtudiantDAO etudiantRepo;
        public EtudiantBLO(string dbFolder)
        {
            etudiantRepo = new EtudiantDAO(dbFolder);
        }
        public void CreateEtudiant(Etudiant etudiant)
        {
            etudiantRepo.Add(etudiant);
        }

        public void DeleteEtudiant(Etudiant etudiant)
        {
            etudiantRepo.Remove(etudiant);
        }


        public IEnumerable<Etudiant> GetAllEtudiant()
        {
            return etudiantRepo.Find();
        }


        public IEnumerable<Etudiant> GetByName(string name)
        {
            return etudiantRepo.Find(x => x.Nom == name);
        }

        public IEnumerable<Etudiant> GetBy(Func<Etudiant, bool> predicate)
        {
            return etudiantRepo.Find(predicate);
        }

        public void EditEtudiant(Etudiant oldEtudiant, Etudiant newEtudiant)
        {
            etudiantRepo.Set(oldEtudiant, newEtudiant);
        }
    }
}

