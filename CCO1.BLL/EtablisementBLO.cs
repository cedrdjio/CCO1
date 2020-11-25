
using CCO1.DAL;
using CCO1.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO1.BLL
{
    public class EtablissementBLO
    {
        EtablissementDAO EtablissementRepo;
        public EtablissementBLO(string dbFolder)
        {
            EtablissementRepo = new EtablissementDAO(dbFolder);
        }
        public void CreateEtablissement(Etablissement Etablissement)
        {
            EtablissementRepo.Add(Etablissement);
        }
        public void DeleteEtablissement(Etablissement Etablissement)
        {
            EtablissementRepo.Remove(Etablissement);
        }
        public IEnumerable<Etablissement> GetAllEtablissement()
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

        public void EditEtablissement(Etablissement oldEtablissement, Etablissement newEtablissement)
        {
            EtablissementRepo.Set(oldEtablissement, newEtablissement);
        }
    }
}

