using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace board_games.Model.GameOfLife.Cards.Effect.Tests
{
    [TestClass]
    public class SpinnerConditionalEffectTest
    {
        [TestMethod]
        public void Constructor_NoAdditionalEffect_SetsAdditionalEffectToNull()
        {
            var spinnerConditionalEffect = new SpinnerConditionalEffect();
            Assert.IsNull(spinnerConditionalEffect.GetAdditionalEffect());
        }

        [TestMethod]
        public void Constructor_WithAdditionalEffect_SetsAdditionalEffect()
        {
            var mockAdditionalEffect = new Mock<IEffect>().Object;
            var spinnerConditionalEffect = new SpinnerConditionalEffect(mockAdditionalEffect);
            Assert.AreEqual(mockAdditionalEffect, spinnerConditionalEffect.GetAdditionalEffect());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException()
        {
            var spinnerConditionalEffect = new SpinnerConditionalEffect();
            spinnerConditionalEffect.DoEffect();
        }
    }
}
