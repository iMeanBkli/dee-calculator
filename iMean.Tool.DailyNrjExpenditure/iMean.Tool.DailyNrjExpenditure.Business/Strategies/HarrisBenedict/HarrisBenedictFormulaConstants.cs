using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.HarrisBenedict
{
    public class HarrisBenedictFormulaConstants : FormulaConstants
    {
        protected override void InitializeConstants()
        {
            var bmrConstant = new Constant<decimal>();
            bmrConstant.AddOrUpdateValue(Gender.Female, 655.1m);
            bmrConstant.AddOrUpdateValue(Gender.Male, 66.5m);

            _formulaConstants.Add(BmrConstantName, bmrConstant);

            var weightConstant = new Constant<decimal>();
            weightConstant.AddOrUpdateValue(Gender.Female, 9.563m);
            weightConstant.AddOrUpdateValue(Gender.Male, 13.75m);

            _formulaConstants.Add(WeightConstantName, weightConstant);

            var heightConstant = new Constant<decimal>();
            heightConstant.AddOrUpdateValue(Gender.Female, 1.850m);
            heightConstant.AddOrUpdateValue(Gender.Male, 5.003m);

            _formulaConstants.Add(HeightConstantName, heightConstant);

            var ageConstant = new Constant<decimal>();
            ageConstant.AddOrUpdateValue(Gender.Female, 4.676m);
            ageConstant.AddOrUpdateValue(Gender.Male, 6.755m);

            _formulaConstants.Add(AgeConstantName, ageConstant);
        }
    }
}
