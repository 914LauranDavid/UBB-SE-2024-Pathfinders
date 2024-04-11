using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace board_games.Model.GameOfLife.Cards.Effect
{
    public class SalaryModifyEffect : IEffect
    {
        private readonly int _salaryModifyAmount;

        public SalaryModifyEffect(int salaryModifyAmount)
        {
            this._salaryModifyAmount = salaryModifyAmount;
            this._additionalEffect = null;
        }

        public SalaryModifyEffect(int salaryModifyAmount, IEffect additionalEffect)
        {
            this._salaryModifyAmount = salaryModifyAmount;
            this._additionalEffect = additionalEffect;
        }

        public override void DoEffect()
        {
            throw new NotImplementedException("DoEffect will be implemented");
        }
    }
}
