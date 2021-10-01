using FootballHub.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHub.Core.Tests.Mocks
{
    public class RepositoryMock<T> : IRepository<T> where T : class
    {
        public List<T> AllItems;
        public RepositoryMock()
        {
            AllItems = new List<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return AllItems;
        }

        public void Insert(T obj)
        {
            AllItems.Add(obj);
        }
    }
}
