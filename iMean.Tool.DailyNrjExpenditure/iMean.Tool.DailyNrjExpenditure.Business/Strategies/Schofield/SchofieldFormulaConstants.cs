using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.Schofield;

public sealed class SchofieldFormulaConstants : FormulaConstants
{
    protected override void InitializeConstants()
    {
        var bmrConstant = new Constant<decimal>();
        bmrConstant.AddOrUpdateValue(Gender.Female, 447.593m);
        bmrConstant.AddOrUpdateValue(Gender.Male, 88.362m);

        _formulaConstants.Add(BmrBaseConstantName, bmrConstant);

        var weightConstant = new Constant<decimal>();
        weightConstant.AddOrUpdateValue(Gender.Female, 9.247m);
        weightConstant.AddOrUpdateValue(Gender.Male, 13.397m);

        _formulaConstants.Add(WeightConstantName, weightConstant);

        var heightConstant = new Constant<decimal>();
        heightConstant.AddOrUpdateValue(Gender.Female, 3.098m);
        heightConstant.AddOrUpdateValue(Gender.Male, 4.799m);

        _formulaConstants.Add(HeightConstantName, heightConstant);

        var ageConstant = new Constant<decimal>();
        ageConstant.AddOrUpdateValue(Gender.Female, 4.330m);
        ageConstant.AddOrUpdateValue(Gender.Male, 5.677m);

        _formulaConstants.Add(AgeConstantName, ageConstant);
    }
}
