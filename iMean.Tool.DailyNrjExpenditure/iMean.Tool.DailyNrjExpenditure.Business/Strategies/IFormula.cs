using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies;

public interface IFormula
{
    EnergyExpenditure Compute(BodyInfo bodyInfo);
}
