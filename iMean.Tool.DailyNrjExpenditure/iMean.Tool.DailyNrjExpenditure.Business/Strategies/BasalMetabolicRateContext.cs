using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies;

public sealed class BasalMetabolicRateContext
{
    public EnergyExpenditure Compute(BodyInfo bodyInfo, IFormula formula)
    {
        return formula.Compute(bodyInfo);
    }
}
