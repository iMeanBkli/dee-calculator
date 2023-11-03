using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business;

public interface ILeanBodyMassCalculator
{
    decimal Compute(BodyInfo bodyInfo);
}
