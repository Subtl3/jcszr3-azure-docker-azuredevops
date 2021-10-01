using FootballHub.Core.Models;
using FootballHub.Core.Repositories;
using FootballHub.Core.Services;
using FootballHub.Core.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FootballHub.Core.Tests.Services
{
    public class ClubServiceTests
    {
        private readonly IRepository<Club> _repository;
        private readonly IClubService sut;

        public ClubServiceTests()
        {
            _repository = new RepositoryMock<Club>();
            sut = new ClubService(_repository);
        }

        [Fact]
        public void Add_New_Returns_Added_Object()
        {
            var club = new Club
            {
                League = "Ekstraklasa",
                Name = "Lechia Gdansk",
                YearFounded = 1945
            };

            sut.AddNew(club);

            var clubs = sut.GetAll();

            Assert.Contains(club, clubs);
        }

    }
}
