using iMean.Tool.DailyNrjExpenditure.Entities;
using iMean.Tool.DailyNrjExpenditure.Entities.Measurement;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies;

public interface IFormula
{
    EnergyExpenditure Compute(BodyInfo bodyInfo);
}
