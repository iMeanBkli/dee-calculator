using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.HarrisBenedict;

public sealed class HarrisBenedictFormula : IHarrisBenedictFormula
{
    private readonly HarrisBenedictFormulaConstants _constants;

    public HarrisBenedictFormula(HarrisBenedictFormulaConstants constants)
    {
        _constants = constants;
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo)
    {
        if (bodyInfo == null) 
            throw new ArgumentNullException(nameof(bodyInfo));

        var bmrConstant = _constants.GetConstantByName(FormulaConstants.BmrConstantName);
        var weightConstant = _constants.GetConstantByName(FormulaConstants.WeightConstantName);
        var heightConstant = _constants.GetConstantByName(FormulaConstants.HeightConstantName);
        var ageConstant = _constants.GetConstantByName(FormulaConstants.AgeConstantName);

        var weight = ApplyConstant(bodyInfo.Weight.Value, bodyInfo.Gender, weightConstant);
        var height = ApplyConstant(bodyInfo.Height.Value, bodyInfo.Gender, heightConstant);
        var age = ApplyConstant(bodyInfo.Age.Value, bodyInfo.Gender, ageConstant);

        var result = bmrConstant.GetValue(bodyInfo.Gender) + weight + height - age;

        return new EnergyExpenditure(result);
    }

    private decimal ApplyConstant(decimal value, Gender gender, Constant<decimal> constant)
    {
        return decimal.Multiply(constant.GetValue(gender), value);
    }
}
