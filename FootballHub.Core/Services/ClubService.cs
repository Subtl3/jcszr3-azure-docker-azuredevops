using FootballHub.Core.Models;
using FootballHub.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace FootballHub.Core.Services
{
    public class ClubService : IClubService
    {
        private readonly IRepository<Club> _clubRepo;

        public ClubService(IRepository<Club> clubRepo)
        {
            _clubRepo = clubRepo;
        }

        public void AddNew(Club club) => _clubRepo.Insert(club);

        public List<Club> GetAll() => _clubRepo.GetAll().ToList();
    }
}
