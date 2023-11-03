using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.MifflinStJeor;

public sealed class MifflinStJeorFormulaConstants : FormulaConstants
{
    protected override void InitializeConstants()
    {
        var bmrConstant = new Constant<decimal>();
        bmrConstant.AddOrUpdateValue(Gender.Female, -161m);
        bmrConstant.AddOrUpdateValue(Gender.Male, 5m);

        _formulaConstants.Add(BmrBaseConstantName, bmrConstant);

        var weightConstant = new Constant<decimal>();
        weightConstant.AddOrUpdateValue(Gender.Female, 10m);
        weightConstant.AddOrUpdateValue(Gender.Male, 10m);

        _formulaConstants.Add(WeightConstantName, weightConstant);

        var heightConstant = new Constant<decimal>();
        heightConstant.AddOrUpdateValue(Gender.Female, 6.25m);
        heightConstant.AddOrUpdateValue(Gender.Male, 6.25m);

        _formulaConstants.Add(HeightConstantName, heightConstant);

        var ageConstant = new Constant<decimal>();
        ageConstant.AddOrUpdateValue(Gender.Female, 5m);
        ageConstant.AddOrUpdateValue(Gender.Male, 5m);

        _formulaConstants.Add(AgeConstantName, ageConstant);
    }
}
