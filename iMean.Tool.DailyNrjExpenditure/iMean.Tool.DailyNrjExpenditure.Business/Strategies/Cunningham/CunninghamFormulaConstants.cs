using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.Cunningham;

public sealed class CunninghamFormulaConstants : FormulaConstants
{
    public const string LeanBodyMassConstantName = "CunninghamLbmConstant";

    protected override void InitializeConstants()
    {
        var bmrConstant = new Constant<decimal>();
        bmrConstant.AddOrUpdateValue(Gender.Female, 500m);
        bmrConstant.AddOrUpdateValue(Gender.Male, 500m);

        _formulaConstants.Add(BmrBaseConstantName, bmrConstant);

        var leanBodyMassConstant = new Constant<decimal>();
        leanBodyMassConstant.AddOrUpdateValue(Gender.Female, 22m);
        leanBodyMassConstant.AddOrUpdateValue(Gender.Male, 22m);

        _formulaConstants.Add(LeanBodyMassConstantName, leanBodyMassConstant);
    }
}
