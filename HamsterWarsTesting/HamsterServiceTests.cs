using Service.Contracts;
using Service;
using Moq;
using Contracts;
using AutoMapper;
using SharedHelpers.DataTransferObjects;
using Entities.Models;
using System.Xml.Linq;
using Castle.Components.DictionaryAdapter.Xml;

namespace HamsterWarsTesting
{
    public class HamsterServiceTests
    {
        private readonly IServiceManager _serviceManager;
        private readonly Mock<IRepositoryManager> _repositoryManagerMok = new Mock<IRepositoryManager>();
        private readonly Mock<ILoggerManager> _loggerManagerMok = new Mock<ILoggerManager>();
        private readonly Mock<IMapper> _mapperMok = new Mock<IMapper>();

        public HamsterServiceTests()
        {
            _serviceManager = new ServiceManager(_repositoryManagerMok.Object, _loggerManagerMok.Object, _mapperMok.Object);
        }
        [Fact]
        public async void test()
        {
            //Arrange
            var hamsterId = 1;
            bool trackChanges = false;
            var hamsterD = new Hamster
            {
                Id = hamsterId,
                Name = "Edwin",
                Age = 1,
                FavFood = "Inget",
                Loves = "Inget",
                ImgName = "jalla123",
                Wins = 1,
                Defeats = 1,
                Games = 2
            };


            _repositoryManagerMok.Setup(x => x.Hamster.GetHamsterAsync(hamsterId, trackChanges)).ReturnsAsync(hamsterD);


            //Act
            var hamster = await _serviceManager.Hamster.GetHamsterAsync(hamsterId, trackChanges);

            //Assert

            Assert.Equal(hamsterId, hamsterD.Id);
        }
    }
}