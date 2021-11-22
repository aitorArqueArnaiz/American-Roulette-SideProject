namespace Roulette.UnitTest
{
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

    public class UnitTest
    {
        #region class variables

        private IGameService _gameService;
        private IBetRepository _repository;
        private const int _directBetPayback = 35;

        #endregion

        #region Class set up

        [SetUp]
        public void Setup()
        {
            //  Create DB context options
            var options = new DbContextOptionsBuilder<BaseRepository<Entity, DbContext>>()
                        .UseInMemoryDatabase("TestDB")
                        .EnableSensitiveDataLogging()
                        .Options;

            // Initiañlize in memmory repository
            _repository = new BetRepository(options);

            // Initialize the game service
            _gameService = new GameService(_repository);
        }

        [TearDown]
        public void TearDown()
        {
            _gameService = null;
            _repository = null;
        }

        #endregion

        #region tests

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("User makes a bet use case test")]
        public void UserBet_Test()
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
            var result = _repository.GetAllUserBets()[0];
            Assert.NotNull(result);
            Assert.AreEqual(result.Id, bet.bet.Id);
            Assert.AreEqual(result.Number, bet.bet.Number);
            Assert.AreEqual(result.ammount, bet.bet.ammount);
            Assert.AreEqual(result.type, bet.bet.type);
        }

        [Test]
        [Author("Aitor Arqué Arnaiz")]
        [Description("User makes a NULL/UNDEFINED bet and and EXCEPTION in thrown")]
        public void UserBet_Null_Bet_Test()
        {
            // Arrange
            var bet = new Bet()
            {
                bet = new Entity()
                {
                    Id = 123456,
                    Number = 36,
                    ammount = 100,
                    type = (int)BetType.Undefined
                }
            };

            // Act && Assert exception
            Assert.Throws<Exception>(() => _gameService.UserBet(bet));
        }

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
                    ammount = 500,
                    type = (int)BetType.Direct
                }
            };

            // Act
            _gameService.Wheel();
            bet.bet.Number = _gameService.GetWheelValue();
            double? win = _gameService.ProcesBetDirect(bet);

            // Assert
            Assert.NotNull(win);
            Assert.AreEqual(_directBetPayback * bet.bet.ammount, win, 
                           $"Expected {_directBetPayback * bet.bet.ammount}, but received {win}");
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