using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;
using iMean.Tool.DailyNrjExpenditure.Utils.Extensions;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.Cunningham;

public sealed class CunninghamFormula : ICunninghamFormula
{
    private readonly CunninghamFormulaConstants _constants;
    private readonly ILeanBodyMassCalculator _leanBodyMassCalculator;

    public CunninghamFormula(CunninghamFormulaConstants constants ,ILeanBodyMassCalculator leanBodyMassCalculator)
    {
        _constants = constants;
        _leanBodyMassCalculator = leanBodyMassCalculator;
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo)
    {
        if (bodyInfo == null) 
            throw new ArgumentNullException(nameof(bodyInfo));

        var bmrConstant = _constants.GetConstantByName(FormulaConstants.BmrBaseConstantName);
        var leanBodyMassConstant = _constants.GetConstantByName(CunninghamFormulaConstants.LeanBodyMassConstantName);

        var leanBodyMass = _leanBodyMassCalculator.Compute(bodyInfo);

        var bmr = bmrConstant.GetValueForGender(bodyInfo.Gender) + leanBodyMass.MultiplyBy(leanBodyMassConstant.GetValueForGender(bodyInfo.Gender));

        return new EnergyExpenditure(bmr);
    }
}
