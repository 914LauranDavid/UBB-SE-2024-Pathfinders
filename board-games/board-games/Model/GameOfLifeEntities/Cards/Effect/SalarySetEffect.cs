using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class SalarySetEffect : IEffect
    {
        private readonly int _salarySetAmount;

        public SalarySetEffect(int salarySetAmount)
        {
            this._salarySetAmount = salarySetAmount;
            this._additionalEffect = null;
        }

        public SalarySetEffect(int salarySetAmount, IEffect additionalEffect)
        {
            this._salarySetAmount = salarySetAmount;
            this._additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }

        public override string serializeIntoConstructorString()
        {
            if (this._additionalEffect == null)
            {
                return this.GetType().Name + "(" + this._salarySetAmount + ")";
            }
            else
            {
                return this.GetType().Name + "(" + this._salarySetAmount + "," + this._additionalEffect.serializeIntoConstructorString() + ")";
            }
        }
    }
}
