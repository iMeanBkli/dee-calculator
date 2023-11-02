using iMean.Tool.DailyNrjExpenditure.Business.Strategies;
using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;

namespace iMean.Tool.DailyNrjExpenditure.Business;

public interface IDailyEnergyExpenditureCalculator
{
    EnergyExpenditure Compute(BodyInfo bodyInfo, ActivityLevel activityLevel, IFormula formula);
}
