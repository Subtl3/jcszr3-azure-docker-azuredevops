using FootballHub.Core.Models;
using FootballHub.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace FootballHub.Core.Services
{
    public class FootballerService : IFootballerService
    {
        private readonly IRepository<Footballer> _footballerRepo;

        public FootballerService(IRepository<Footballer> footballerRepo)
        {
            _footballerRepo = footballerRepo;
        }

        public void AddNew(Footballer footballer) => _footballerRepo.Insert(footballer);

        public List<Footballer> GetAll() => _footballerRepo.GetAll().ToList();
    }
}
