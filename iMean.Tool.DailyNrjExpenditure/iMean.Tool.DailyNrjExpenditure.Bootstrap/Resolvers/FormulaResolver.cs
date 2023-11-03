using iMean.Tool.DailyNrjExpenditure.Business.Strategies;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Cunningham;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.HarrisBenedict;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.KatchMcArdle;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.MifflinStJeor;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Owen;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Schofield;

namespace iMean.Tool.DailyNrjExpenditure.Bootstrap.Resolvers;

public class FormulaResolver : IFormulaResolver
{
    private readonly IServiceProvider _serviceProvider;

    private readonly Dictionary<string, Type> _registeredFormulas = new Dictionary<string, Type>
    {
        { nameof(ICunninghamFormula), typeof(ICunninghamFormula) },
        { nameof(IHarrisBenedictFormula), typeof(IHarrisBenedictFormula) },
        { nameof(IKatchMcArdleFormula), typeof(IKatchMcArdleFormula) },
        { nameof(IMifflinStJeorFormula), typeof(IMifflinStJeorFormula) },
        { nameof(IOwenFormula), typeof(IOwenFormula) },
        { nameof(ISchofieldFormula), typeof(ISchofieldFormula) },
    };

    public FormulaResolver(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public IFormula GetFormulaByName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentNullException(nameof(name));

        if (_registeredFormulas.TryGetValue(name, out var formula))
            return (IFormula)_serviceProvider.GetService(formula);

        throw new KeyNotFoundException(name);
    }
}
