using PersonApplication.DataAccess.Models;
using System.Collections.Generic;

namespace PersonApplication.DataAccess.Repository
{
    public interface IPersonRepository : IGenericRepository <Person>
    {
          new IEnumerable<Person> GetAll();
    }
}
