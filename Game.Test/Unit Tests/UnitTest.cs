using Game.Domain.Interfaces;
using Game.Domain.Services;
using NUnit.Framework;

namespace Game.UnitTest
{
    public class UnitTest
    {
        #region class variables

        private IGameService _gameService;

        #endregion

        #region Class set up

        [SetUp]
        public void Setup()
        {
            _gameService = new GameService();
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

            // Act

            // Assert
            Assert.Pass();
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