using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    
        public interface IRepository<T>
        {
            void Add(T entity);
            List<T> GetAll();
            void Delete(int id);
            void Update(T entity);
            T GetById(int id);
        }
    

}
