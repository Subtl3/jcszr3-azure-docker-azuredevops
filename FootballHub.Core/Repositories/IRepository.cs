using System.Collections.Generic;

namespace FootballHub.Core.Repositories
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Insert(T obj);
    }
}
