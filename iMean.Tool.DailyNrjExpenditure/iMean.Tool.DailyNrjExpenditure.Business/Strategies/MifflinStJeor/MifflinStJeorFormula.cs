using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;
using iMean.Tool.DailyNrjExpenditure.Utils.Extensions;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.MifflinStJeor;

public sealed class MifflinStJeorFormula : IMifflinStJeorFormula
{
    private readonly MifflinStJeorFormulaConstants _constants;

    public MifflinStJeorFormula(MifflinStJeorFormulaConstants constants)
    {
        _constants = constants;
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo)
    {
        if (bodyInfo == null) 
            throw new ArgumentNullException(nameof(bodyInfo));

        var bmrConstant = _constants.GetConstantByName(FormulaConstants.BmrBaseConstantName);
        var weightConstant = _constants.GetConstantByName(FormulaConstants.WeightConstantName);
        var heightConstant = _constants.GetConstantByName(FormulaConstants.HeightConstantName);
        var ageConstant = _constants.GetConstantByName(FormulaConstants.AgeConstantName);

        var weight = bodyInfo.Weight.Value.MultiplyBy(weightConstant.GetValueForGender(bodyInfo.Gender));
        var height = bodyInfo.Height.Value.MultiplyBy(heightConstant.GetValueForGender(bodyInfo.Gender));
        var age = bodyInfo.Age.Value.MultiplyBy(ageConstant.GetValueForGender(bodyInfo.Gender));

        var bmr = bmrConstant.GetValueForGender(bodyInfo.Gender) + weight + height - age;

        return new EnergyExpenditure(bmr);
    }
}
