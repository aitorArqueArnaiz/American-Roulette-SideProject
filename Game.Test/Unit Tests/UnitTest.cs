using Game.Domain.Entities;
using Game.Domain.Interfaces;
using Game.Domain.Services;
using Game.Infrastructure.Data;
using Game.Infrastructure.Data.Repositories;
using Game.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using static Game.Domain.Shared.Enums;

namespace Game.UnitTest
{
    public class UnitTest
    {
        #region class variables

        private IGameService _gameService;
        private IBaseRepository<Entity> _repository;

        #endregion

        #region Class set up

        [SetUp]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<BaseRepository<Entity, DbContext>>()
                        .UseInMemoryDatabase(Guid.NewGuid().ToString())
                        .EnableSensitiveDataLogging()
                        .Options;

            _repository = new BetRepository(options);
            _gameService = new GameService(_repository);
        }

        [TearDown]
        public void TearDown()
        {
        }

        #endregion

        #region tests

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet direct use case")]
        public void Bet_Direct_test()
        {
            // Arrange
            var bet = new Bet()
            {
                bet = new Entity()
                {
                    Id = 123456,
                    Number = 36,
                    ammount = 100,
                    type = (int)BetType.Direct
                }
            };

            // Act
            _gameService.UserBet(bet);

            // Assert
            Assert.NotNull(_repository.GetAll().Result);
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet divided use case")]
        public void Bet_Divided_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet street use case")]
        public void Bet_Street_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet corner use case")]
        public void Bet_Corner_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet five numbers use case")]
        public void Bet_FiveNumbers_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet Line use case")]
        public void Bet_Line_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet dozen use case")]
        public void Bet_Dozen_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet column use case")]
        public void Bet_Column_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet double dozen use case")]
        public void Bet_Double_Dozen_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet double column use case")]
        public void Bet_Double_Column_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet colors use case")]
        public void Bet_Colors_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("Bet odds use case")]
        public void Bet_Odds_test()
        {
            // Arrange

            // Act

            // Assert
            Assert.Pass();
        }

        #endregion

        #region Helper methods



        #endregion
    }
}