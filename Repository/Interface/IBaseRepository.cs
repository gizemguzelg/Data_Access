using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperExample.Repository.Interface
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        bool Insert(T item);
        bool Update(T item);
        bool Delete(T item);



    }
}
