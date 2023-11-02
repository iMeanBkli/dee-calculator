using iMean.Tool.DailyNrjExpenditure.Business.Strategies;

namespace iMean.Tool.DailyNrjExpenditure.Bootstrap.Resolvers;

public interface IFormulaResolver
{
    IFormula GetFormulaByName(string name);
}
