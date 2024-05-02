using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace board_games.Model.GameOfLife.Cards.Effect.Tests
{
    [TestClass]
    public class MoneyEffectTest
    {
        [TestMethod]
        public void Constructor_NoAdditionalEffect_SetsMoneyAmountAndAdditionalEffectToNull()
        {
            int moneyAmount = 100;

            var moneyEffect = new MoneyEffect(moneyAmount);

            Assert.AreEqual(moneyAmount, moneyEffect.GetMoneyAmount());
            Assert.IsNull(moneyEffect.GetAdditionalEffect());
        }

        [TestMethod]
        public void Constructor_WithAdditionalEffect_SetsMoneyAmountAndAdditionalEffect()
        {
            int moneyAmount = 100;
            var mockAdditionalEffect = new Mock<IEffect>().Object;

            var moneyEffect = new MoneyEffect(moneyAmount, mockAdditionalEffect);

            Assert.AreEqual(moneyAmount, moneyEffect.GetMoneyAmount());
            Assert.AreEqual(mockAdditionalEffect, moneyEffect.GetAdditionalEffect());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException()
        {
            var moneyEffect = new MoneyEffect(100);
            moneyEffect.DoEffect();
        }
    }
}
