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
    public class FootballerServiceTests
    {
        private readonly IRepository<Footballer> _repository;
        private readonly IFootballerService _sut;
        public FootballerServiceTests()
        {
            _repository = new RepositoryMock<Footballer>() { AllItems = new List<Footballer>() { 
                new Footballer() { Name = "Adam", Surname = "Ledwoń", Number = 4, Position = "Defender" },
                new Footballer() { Name = "Tomasz", Surname = "Kłos", Number = 3, Position = "Defender" },
                new Footballer() { Name = "Flavio", Surname = "Paixao", Number = 28, Position = "Striker" }
            } };
            _sut = new FootballerService(_repository);
        }

        [Fact]
        public void Get_All_Returns_Expected_Objects()
        {
            var footballers = _sut.GetAll();

            Assert.Equal(3, footballers.Count);
        }
    }
}
