using FootballHub.Core.Models;
using System.Collections.Generic;

namespace FootballHub.Core.Services
{
    public interface IFootballerService
    {
        List<Footballer> GetAll();
        void AddNew(Footballer footballer);
    }
}
