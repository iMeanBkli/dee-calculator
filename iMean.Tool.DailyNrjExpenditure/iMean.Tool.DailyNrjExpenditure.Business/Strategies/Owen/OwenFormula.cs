using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;
using iMean.Tool.DailyNrjExpenditure.Utils.Extensions;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.Owen;

public sealed class OwenFormula : IOwenFormula
{
    private readonly OwenFormulaConstants _constants;

    public OwenFormula(OwenFormulaConstants constants)
    {
        _constants = constants;
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo)
    {
        if (bodyInfo == null)
            throw new ArgumentNullException(nameof(bodyInfo));

        var bmrConstant = _constants.GetConstantByName(FormulaConstants.BmrBaseConstantName);
        var weightConstant = _constants.GetConstantByName(FormulaConstants.WeightConstantName);

        var weight = bodyInfo.Weight.Value.MultiplyBy(weightConstant.GetValueForGender(bodyInfo.Gender));

        var bmr = bmrConstant.GetValueForGender(bodyInfo.Gender) + weight;

        return new EnergyExpenditure(bmr);
    }
}
