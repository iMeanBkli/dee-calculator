using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.Owen;

public sealed class OwenFormulaConstants : FormulaConstants
{
    protected override void InitializeConstants()
    {
        var bmrConstant = new Constant<decimal>();
        bmrConstant.AddOrUpdateValue(Gender.Female, 879m);
        bmrConstant.AddOrUpdateValue(Gender.Male, 879m);

        _formulaConstants.Add(BmrBaseConstantName, bmrConstant);

        var weightConstant = new Constant<decimal>();
        weightConstant.AddOrUpdateValue(Gender.Female, 10.2m);
        weightConstant.AddOrUpdateValue(Gender.Male, 10.2m);

        _formulaConstants.Add(WeightConstantName, weightConstant);
    }
}
