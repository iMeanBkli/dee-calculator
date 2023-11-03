using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Constants;

public sealed class LeanBodyMassBoerFormulaConstants : FormulaConstants
{
    public const string LeanBodyMassBaseConstantName = "LbmBaseConstant";
    public const string LeanBodyMassWeightConstantName = "LbmWeightConstant";
    public const string LeanBodyMassHeightConstantName = "LbmHeightConstant";

    protected override void InitializeConstants()
    {
        var lbmBaseConstant = new Constant<decimal>();
        lbmBaseConstant.AddOrUpdateValue(Gender.Female, 48.3m);
        lbmBaseConstant.AddOrUpdateValue(Gender.Male, 19.2m);

        _formulaConstants.Add(LeanBodyMassBaseConstantName, lbmBaseConstant);

        var lbmWeightConstant = new Constant<decimal>();
        lbmWeightConstant.AddOrUpdateValue(Gender.Female, 0.252m);
        lbmWeightConstant.AddOrUpdateValue(Gender.Male, 0.407m);

        _formulaConstants.Add(LeanBodyMassWeightConstantName, lbmWeightConstant);

        var lbmHeightConstant = new Constant<decimal>();
        lbmHeightConstant.AddOrUpdateValue(Gender.Female, 0.473m);
        lbmHeightConstant.AddOrUpdateValue(Gender.Male, 0.267m);

        _formulaConstants.Add(LeanBodyMassHeightConstantName, lbmHeightConstant);
    }
}
