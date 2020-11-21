using CCO1.BO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCO1.DAL
{
    public class EtudiantDAO
    {
        private static List<Etudiant> Etudiant;
        private const string FILE_NAME = @"Etudiant.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EtudiantDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }
            if (file.Length > 0)
            {
                using (StreamReader sr = new StreamReader(file.FullName))
                {
                    string json = sr.ReadToEnd();
                    Etudiant = JsonConvert.DeserializeObject<List<Etudiant>>(json);
                }
            }
            if (Etudiant == null)
            {
                Etudiant = new List<Etudiant>();
            }
        }

        public void Set(Etudiant oldProduct, Etudiant newProduct)
        {
            var oldIndex = Etudiant.IndexOf(oldProduct);
            var newIndex = Etudiant.IndexOf(newProduct);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The etudiant doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This etudiant reference already exists !");
            Etudiant[oldIndex] = newProduct;
            Save();
        }

        public void Add(Etudiant etudiant)
        {
            var index = Etudiant.IndexOf(etudiant);
            if (index >= 0)
                throw new DuplicateNameException("This etudiant reference already exists !");
            Etudiant.Add(etudiant);
            Save();
        }

        private void Save()
        {
            using (StreamWriter sw = new StreamWriter(file.FullName, false))
            {
                string json = JsonConvert.SerializeObject(Etudiant);
                sw.WriteLine(json);
            }
        }

        public void Remove(Etudiant etudiant)
        {
            Etudiant.Remove(etudiant);
            Save();
        }

        public IEnumerable<Etudiant> Find()
        {
            return new List<Etudiant>(Etudiant);
        }

        public IEnumerable<Etudiant> Find(Func<Etudiant, bool> predicate)
        {
            return new List<Etudiant>(Etudiant.Where(predicate).ToArray());
        }
    }
}