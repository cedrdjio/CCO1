
using CCO1.DAL;
using CCO1.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EtablissementBLO
    {
        EtablissementDAO EtablissementRepo;
        public EtablissementBLO(string dbFolder)
        {
            EtablissementRepo = new EtablissementDAO(dbFolder);
        }
        public void CreateUniversity(Etablissement Etablissement)
        {
            EtablissementRepo.Add(Etablissement);
        }
        public void DeleteUniversity(Etablissement Etablissement)
        {
            EtablissementRepo.Remove(Etablissement);
        }
        public IEnumerable<Etablissement> GetAllUniversitys()
        {
            return EtablissementRepo.Find();
        }
        public IEnumerable<Etablissement> GetByName(string Name)
        {
            return EtablissementRepo.Find(x => x.NomEtablissement == Name);
        }

        public IEnumerable<Etablissement> GetBy(Func<Etablissement, bool> predicate)
        {
            return EtablissementRepo.Find(predicate);
        }

        public void EditUniversity(Etablissement oldEtablissement, Etablissement newEtablissement)
        {
            EtablissementRepo.Set(oldEtablissement, newEtablissement);
        }
    }
}

