using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace board_games.Model.GameOfLife.Cards.Effect.Tests
{
    [TestClass]
    public class SalarySetEffectTest
    {
        [TestMethod]
        public void Constructor_NoAdditionalEffect_SetsSalarySetAmountAndAdditionalEffectToNull()
        {
            int salarySetAmount = 100;

            var salarySetEffect = new SalarySetEffect(salarySetAmount);

            Assert.AreEqual(salarySetAmount, salarySetEffect.GetSalaryAmount());
            Assert.IsNull(salarySetEffect.GetAdditionalEffect());
        }

        [TestMethod]
        public void Constructor_WithAdditionalEffect_SetsSalarySetAmountAndAdditionalEffect()
        {
            int salarySetAmount = 100;
            var mockAdditionalEffect = new Mock<IEffect>().Object;

            var salarySetEffect = new SalarySetEffect(salarySetAmount, mockAdditionalEffect);

            Assert.AreEqual(salarySetAmount, salarySetEffect.GetSalaryAmount());
            Assert.AreEqual(mockAdditionalEffect, salarySetEffect.GetAdditionalEffect());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException()
        {
            var salarySetEffect = new SalarySetEffect(100);

            salarySetEffect.DoEffect();
        }
    }
}
