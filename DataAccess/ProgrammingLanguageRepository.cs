using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProgrammingLanguageRepository : IRepository<ProgrammingLanguage>
    {
        private List<ProgrammingLanguage> _languages = new List<ProgrammingLanguage>();

        public void Add(ProgrammingLanguage entity) => _languages.Add(entity);

        public List<ProgrammingLanguage> GetAll() => _languages;

        public void Delete(int id) => _languages.RemoveAll(l => l.Id == id);

        public void Update(ProgrammingLanguage entity)
        {
            var lang = _languages.FirstOrDefault(l => l.Id == entity.Id);
            if (lang != null) lang.Name = entity.Name;
        }

        public ProgrammingLanguage GetById(int id) => _languages.FirstOrDefault(l => l.Id == id);
    }
}
