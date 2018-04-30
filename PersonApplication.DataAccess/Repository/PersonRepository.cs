using System.Data.Entity;
using PersonApplication.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonApplication.DataAccess.Repository
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {

        public PersonRepository(DbContext context) : base(context)
        {
        }
        public override IEnumerable<Person> GetAll()
        {
            return _dbset.Where(e => e.IsDeleted == false).Include("PersonAddress");
        }
    }
}
