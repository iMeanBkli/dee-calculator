using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.KatchMcArdle;

public sealed class KatchMcArdleFormulaConstants : FormulaConstants
{
    public const string KatchMcArdleLeanBodyMassConstantName = "KatchMcArdleLbmConstant";

    protected override void InitializeConstants()
    {
        var bmrConstant = new Constant<decimal>();
        bmrConstant.AddOrUpdateValue(Gender.Female, 370m);
        bmrConstant.AddOrUpdateValue(Gender.Male, 370m);

        _formulaConstants.Add(BmrBaseConstantName, bmrConstant);

        var leanBodyMassConstant = new Constant<decimal>();
        leanBodyMassConstant.AddOrUpdateValue(Gender.Female, 21.6m);
        leanBodyMassConstant.AddOrUpdateValue(Gender.Male, 21.6m);

        _formulaConstants.Add(WeightConstantName, leanBodyMassConstant);
    }
}
