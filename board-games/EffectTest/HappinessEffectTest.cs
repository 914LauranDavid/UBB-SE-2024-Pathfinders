using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace board_games.Model.GameOfLife.Cards.Effect.Tests
{
    [TestClass]
    public class HappinessEffectTest
    {
        [TestMethod]
        public void Constructor_NoAdditionalEffect_SetsHappinessAmountAndAdditionalEffectToNull()
        {
            int happinessAmount = 10;
            var happinessEffect = new HappinessEffect(happinessAmount);

            Assert.AreEqual(happinessAmount, happinessEffect.GetHappinessAmount());
            Assert.IsNull(happinessEffect.GetAdditionalEffect());
        }

        [TestMethod]
        public void Constructor_WithAdditionalEffect_SetsHappinessAmountAndAdditionalEffect()
        {
            int happinessAmount = 10;
            var mockAdditionalEffect = new Mock<IEffect>().Object;

            var happinessEffect = new HappinessEffect(happinessAmount, mockAdditionalEffect);

            Assert.AreEqual(happinessAmount, happinessEffect.GetHappinessAmount());
            Assert.AreEqual(mockAdditionalEffect, happinessEffect.GetAdditionalEffect());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException()
        {
            var happinessEffect = new HappinessEffect(10);
            happinessEffect.DoEffect();
        }
    }
}
