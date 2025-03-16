using DataAccess;
using Entities;
using System.Collections.Generic;


// 3. Business (İş Mantığı) Katmanı
namespace Business
{

    public class ProgrammingLanguageManager
    {
        private readonly IRepository<ProgrammingLanguage> _repository;

        public ProgrammingLanguageManager(IRepository<ProgrammingLanguage> repository)
        {
            _repository = repository;
        }

        public void AddLanguage(string name)
        {
            int newId = _repository.GetAll().Count + 1; // ID otomatik artıyor.
            _repository.Add(new ProgrammingLanguage { Id = newId, Name = name });
        }

        public List<ProgrammingLanguage> GetAllLanguages() => _repository.GetAll();
    }
}