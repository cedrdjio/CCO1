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
    public class EtudianDal
    {
        private static List<etudiant> Etudiant;
        private const string FILE_NAME = @"Etudiant.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EtudianDal(string dbFolder)
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
                    Etudiant = JsonConvert.DeserializeObject<List<etudiant>>(json);
                }
            }
            if (Etudiant == null)
            {
                Etudiant = new List<etudiant>();
            }
        }

        public void Set(etudiant oldProduct, etudiant newProduct)
        {
            var oldIndex = Etudiant.IndexOf(oldProduct);
            var newIndex = Etudiant.IndexOf(newProduct);
            if (oldIndex < 0)
                throw new KeyNotFoundException("The product doesn't exists !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("This product reference already exists !");
            Etudiant[oldIndex] = newProduct;
            Save();
        }

        public void Add(etudiant Etudiant)
        {
            var index = Etudiant.IndexOf(etudiant);
            if (index >= 0)
                throw new DuplicateNameException("This product reference already exists !");
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

        public void Remove(etudiant Etudiant)
        {
            Etudiant.Remove(etudiant);//base sur Product.Equals redefini
            Save();
        }

        public IEnumerable<etudiant> Find()
        {
            return new List<etudiant>(Etudiant);
        }

        public IEnumerable<etudiant> Find(Func<etudiant, bool> predicate)
        {
            return new List<etudiant>(Etudiant.Where(predicate).ToArray());
        }
    }
}