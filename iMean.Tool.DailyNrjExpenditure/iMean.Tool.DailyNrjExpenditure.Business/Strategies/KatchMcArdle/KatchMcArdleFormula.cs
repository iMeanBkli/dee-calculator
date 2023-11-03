using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;
using iMean.Tool.DailyNrjExpenditure.Utils.Extensions;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.KatchMcArdle;

public sealed class KatchMcArdleFormula : IKatchMcArdleFormula
{
    private readonly KatchMcArdleFormulaConstants _constants;
    private readonly ILeanBodyMassCalculator _leanBodyMassCalculator;

    public KatchMcArdleFormula(KatchMcArdleFormulaConstants constants, ILeanBodyMassCalculator leanBodyMassCalculator)
    {
        _constants = constants;
        _leanBodyMassCalculator = leanBodyMassCalculator;
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo)
    {
        if (bodyInfo == null) 
            throw new ArgumentNullException(nameof(bodyInfo));

        var bmrConstant = _constants.GetConstantByName(FormulaConstants.BmrBaseConstantName);
        var lbmConstant = _constants.GetConstantByName(KatchMcArdleFormulaConstants.KatchMcArdleLeanBodyMassConstantName);

        var leanBodyMass = _leanBodyMassCalculator.Compute(bodyInfo);
        var bmr = bmrConstant.GetValueForGender(bodyInfo.Gender) + leanBodyMass.MultiplyBy(lbmConstant.GetValueForGender(bodyInfo.Gender));

        return new EnergyExpenditure(bmr);
    }
}
