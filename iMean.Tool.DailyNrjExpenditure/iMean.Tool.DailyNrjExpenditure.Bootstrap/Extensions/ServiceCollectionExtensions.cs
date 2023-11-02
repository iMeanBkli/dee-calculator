using iMean.Tool.DailyNrjExpenditure.Bootstrap.Resolvers;
using iMean.Tool.DailyNrjExpenditure.Business;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Cunningham;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.HarrisBenedict;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.KatchMcArdle;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.MifflinStJeor;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Owen;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Schofield;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Who;
using Microsoft.Extensions.DependencyInjection;

namespace iMean.Tool.DailyNrjExpenditure.Bootstrap.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddDailyEnergyExpenditure(this IServiceCollection services)
    {
        services.AddTransient<HarrisBenedictFormulaConstants>();
        services.AddSingleton<IFormulaResolver, FormulaResolver>();
        services.AddSingleton<BasalMetabolicRateContext>();
        services.AddTransient<ICunninghamFormula, CunninghamFormula>();
        services.AddTransient<IHarrisBenedictFormula, HarrisBenedictFormula>();
        services.AddTransient<IKatchMcArdleFormula, KatchMcArdleFormula>();
        services.AddTransient<IMifflinStJeorFormula, MifflinStJeorFormula>();
        services.AddTransient<IMifflinStJeorRevisedFormula, MifflinStJeorRevisedFormula>();
        services.AddTransient<IOwenFormula, OwenFormula>();
        services.AddTransient<ISchofieldFormula, SchofieldFormula>();
        services.AddTransient<IWorldHealthOrganizationFormula, WorldHealthOrganizationFormula>();
        services.AddSingleton<IDailyEnergyExpenditureCalculator, DailyEnergyExpenditureCalculator>();
    }
}
