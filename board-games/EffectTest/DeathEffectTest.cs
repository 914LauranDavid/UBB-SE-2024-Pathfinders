using board_games.Model.GameOfLife.Cards.Effect;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace board_games.Model.GameOfLife.Cards.Effect.Tests
{
    [TestClass]
    public class DeathEffectTest
    {
        [TestMethod]
        public void Constructor_NoAdditionalEffect()
        {
            var deathEffect = new DeathEffect();
            Assert.IsNull(deathEffect.GetAdditionalEffect());
        }

        [TestMethod]
        public void Constructor_WithAdditionalEffect()
        {
            var mockAdditionalEffect = new Mock<IEffect>().Object;
            var deathEffect = new DeathEffect(mockAdditionalEffect);
            Assert.AreEqual(mockAdditionalEffect, deathEffect.GetAdditionalEffect());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException()
        {
            var deathEffect = new DeathEffect();
            deathEffect.DoEffect();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException_WithAdditionalValue()
        {
            var mockAdditionalEffect = new Mock<IEffect>().Object;
            var deathEffect = new DeathEffect(mockAdditionalEffect);
            deathEffect.DoEffect();
        }

    }
}
