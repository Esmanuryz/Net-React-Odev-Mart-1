using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    // Teknoloji veritabanı işlemleri için kullanılacak sınıf
    
    public class TechnologyRepository : IRepository<Technology>
    {
        private List<Technology> _technologies = new List<Technology>();

        public void Add(Technology entity) => _technologies.Add(entity);

        public List<Technology> GetAll() => _technologies;

        public void Delete(int id) => _technologies.RemoveAll(t => t.Id == id);

        public void Update(Technology entity)
        {
            var tech = _technologies.FirstOrDefault(t => t.Id == entity.Id);
            if (tech != null)
            {
                tech.Name = entity.Name;
                tech.ProgrammingLanguageId = entity.ProgrammingLanguageId;
            }
        }

        public Technology GetById(int id) => _technologies.FirstOrDefault(t => t.Id == id);
    }
}
