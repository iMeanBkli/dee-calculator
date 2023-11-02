using iMean.Tool.DailyNrjExpenditure.Business.Strategies;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;

namespace iMean.Tool.DailyNrjExpenditure.Business;

public class DailyEnergyExpenditureCalculator : IDailyEnergyExpenditureCalculator
{
    private readonly BasalMetabolicRateContext _context;

    public DailyEnergyExpenditureCalculator(BasalMetabolicRateContext context)
    {
        _context = context;
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo, ActivityLevel activityLevel, IFormula formula)
    {
        if (bodyInfo == null)
            throw new ArgumentNullException(nameof(bodyInfo));

        var basalMetabolicRate = _context.Compute(bodyInfo, formula);
        
        ActivityFactor activityFactor = activityLevel;
        var dailyEnergyExpenditure = decimal.Multiply(basalMetabolicRate.Value, activityFactor.Value);

        return new EnergyExpenditure(dailyEnergyExpenditure);
    }
}
