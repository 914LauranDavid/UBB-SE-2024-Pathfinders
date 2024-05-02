using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace board_games.Model.GameOfLife.Cards.Effect.Tests
{
    [TestClass]
    public class SalaryModifyEffectTest
    {
        [TestMethod]
        public void Constructor_NoAdditionalEffect_SetsSalaryModifyAmountAndAdditionalEffectToNull()
        {
            int salaryModifyAmount = 50;
            var salaryModifyEffect = new SalaryModifyEffect(salaryModifyAmount);

            Assert.AreEqual(salaryModifyAmount, salaryModifyEffect.GetSalaryAmount());
            Assert.IsNull(salaryModifyEffect.GetAdditionalEffect());
        }

        [TestMethod]
        public void Constructor_WithAdditionalEffect_SetsSalaryModifyAmountAndAdditionalEffect()
        {
            int salaryModifyAmount = 50;
            var mockAdditionalEffect = new Mock<IEffect>().Object;

            var salaryModifyEffect = new SalaryModifyEffect(salaryModifyAmount, mockAdditionalEffect);

            Assert.AreEqual(salaryModifyAmount, salaryModifyEffect.GetSalaryAmount());
            Assert.AreEqual(mockAdditionalEffect, salaryModifyEffect.GetAdditionalEffect());
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void DoEffect_ThrowsNotImplementedException()
        {
            var salaryModifyEffect = new SalaryModifyEffect(50);
            salaryModifyEffect.DoEffect();
        }
    }
}
