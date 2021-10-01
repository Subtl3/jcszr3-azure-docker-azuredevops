using FootballHub.Core.Models;
using FootballHub.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballHub.Core.Services
{
    public class StadiumService : IStadiumService
    {
        private readonly ITableStorageRepository<Stadium> _repository;
        public StadiumService(ITableStorageRepository<Stadium> repo)
        {
            _repository = repo;
        }

        public void Add(Stadium stadium)
        {
            _repository.Insert(stadium);
        }
    }
}
