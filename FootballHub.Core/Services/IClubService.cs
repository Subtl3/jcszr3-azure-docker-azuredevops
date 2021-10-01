using FootballHub.Core.Models;
using System.Collections.Generic;

namespace FootballHub.Core.Services
{
    public interface IClubService
    {
        List<Club> GetAll();
        void AddNew(Club club);
    }
}
