using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies;

public sealed class BasalMetabolicRateContext
{
    public EnergyExpenditure Compute(BodyInfo bodyInfo, IFormula formula)
    {
        return formula.Compute(bodyInfo);
    }
}
