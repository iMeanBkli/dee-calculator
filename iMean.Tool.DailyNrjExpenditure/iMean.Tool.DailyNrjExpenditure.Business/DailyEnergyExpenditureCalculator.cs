using iMean.Tool.DailyNrjExpenditure.Business.Strategies;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Provider;
using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business;

public class DailyEnergyExpenditureCalculator
{
    private readonly BasalMetabolicRateContext _context;

    public DailyEnergyExpenditureCalculator()
    {
        _context = new BasalMetabolicRateContext();
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo, decimal physicalActivityLevel)
    {
        var formula = FormulaProvider.GetDefaultFormula(bodyInfo);

        return Compute(bodyInfo, physicalActivityLevel, formula);
    }

    public EnergyExpenditure Compute(BodyInfo bodyInfo, decimal physicalActivityLevel, IFormula formula)
    {
        if (bodyInfo == null)
            throw new ArgumentNullException(nameof(bodyInfo));

        var basalMetabolicRate = _context.Compute(bodyInfo, formula);
        var dailyEnergyExpenditure = decimal.Multiply(basalMetabolicRate.Value, physicalActivityLevel);

        return new EnergyExpenditure(dailyEnergyExpenditure);
    }
}
