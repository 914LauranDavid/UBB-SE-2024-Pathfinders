using board_games.Model.GameOfLife.Cards.Effect;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace board_games.Model.GameOfLife.Cards.Effect.Tests
{
    [TestClass]
    public class ConditionalEffectTest
    {
        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly_WithoutAdditionalValue()
        {
            var mockFirstEffect = new Mock<IEffect>();
            var mockSecondEffect = new Mock<IEffect>();

            var conditionalEffect = new ConditionalEffect(mockFirstEffect.Object, mockSecondEffect.Object);

            Assert.AreEqual(mockFirstEffect.Object, conditionalEffect.GetFirstPathEffect());
            Assert.AreEqual(mockSecondEffect.Object, conditionalEffect.GetSecondPathEffect());
            Assert.AreEqual(conditionalEffect.GetAdditionalEffect(), null);

        }

        [TestMethod]
        public void Constructor_SetsPropertiesCorrectly_WithAdditionalValue()
        {
            var mockFirstEffect = new Mock<IEffect>();
            var mockSecondEffect = new Mock<IEffect>();
            var mockAdditionalValue = new Mock<IEffect>();

            var conditionalEffect = new ConditionalEffect(mockFirstEffect.Object, mockSecondEffect.Object, mockAdditionalValue.Object);

            Assert.AreEqual(mockFirstEffect.Object, conditionalEffect.GetFirstPathEffect());
            Assert.AreEqual(mockSecondEffect.Object, conditionalEffect.GetSecondPathEffect());
            Assert.AreEqual(mockAdditionalValue.Object, conditionalEffect.GetAdditionalEffect());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException_WithoutAdditionalValue()
        {
            var mockFirstEffect = new Mock<IEffect>();
            var mockSecondEffect = new Mock<IEffect>();

            var conditionalEffect = new ConditionalEffect(mockFirstEffect.Object, mockSecondEffect.Object);

            conditionalEffect.DoEffect();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException_WithAdditionalValue()
        {
            var mockFirstEffect = new Mock<IEffect>();
            var mockSecondEffect = new Mock<IEffect>();
            var mockAdditionalValue = new Mock<IEffect>();


            var conditionalEffect = new ConditionalEffect(mockFirstEffect.Object, mockSecondEffect.Object, mockAdditionalValue.Object);

            conditionalEffect.DoEffect();
        }



    }
}
