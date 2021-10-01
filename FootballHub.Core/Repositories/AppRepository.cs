using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FootballHub.Core.Repositories
{
    public class AppRepository<T> : IRepository<T> where T : class
    {
        private readonly FootballHubContext _context = null;
        private readonly DbSet<T> table = null;

        public AppRepository(FootballHubContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }
    }
}
