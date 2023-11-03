using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Utils.Extensions;

namespace iMean.Tool.DailyNrjExpenditure.Business;

public class BoerLeanBodyMassCalculator : ILeanBodyMassCalculator
{
    private readonly LeanBodyMassBoerFormulaConstants _constants;

    public BoerLeanBodyMassCalculator(LeanBodyMassBoerFormulaConstants constants)
    {
        _constants = constants;
    }

    public decimal Compute(BodyInfo bodyInfo)
    {
        if (bodyInfo == null)
            throw new ArgumentNullException(nameof(bodyInfo));

        var constant = _constants.GetConstantByName(LeanBodyMassBoerFormulaConstants.LeanBodyMassBaseConstantName);
        var weightConstant = _constants.GetConstantByName(LeanBodyMassBoerFormulaConstants.LeanBodyMassWeightConstantName);
        var heightConstant = _constants.GetConstantByName(LeanBodyMassBoerFormulaConstants.LeanBodyMassHeightConstantName);

        var weight = bodyInfo.Weight.Value.MultiplyBy(weightConstant.GetValueForGender(bodyInfo.Gender));
        var height = bodyInfo.Height.Value.MultiplyBy(heightConstant.GetValueForGender(bodyInfo.Gender));

        return weight + height - constant.GetValueForGender(bodyInfo.Gender);
    }
}
