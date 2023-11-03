using iMean.Tool.DailyNrjExpenditure.Bootstrap.Resolvers;
using iMean.Tool.DailyNrjExpenditure.Business;
using iMean.Tool.DailyNrjExpenditure.Business.Constants;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Cunningham;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.HarrisBenedict;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.KatchMcArdle;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.MifflinStJeor;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Owen;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.Schofield;
using Microsoft.Extensions.DependencyInjection;

namespace iMean.Tool.DailyNrjExpenditure.Bootstrap.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddDailyEnergyExpenditure(this IServiceCollection services)
    {
        //
        // Lean Body Mass
        //
        services.AddTransient<LeanBodyMassBoerFormulaConstants>();
        services.AddSingleton<ILeanBodyMassCalculator, BoerLeanBodyMassCalculator>();
        //
        // Basal Metabolic Rate Formula Constants
        //
        services.AddTransient<CunninghamFormulaConstants>();
        services.AddTransient<HarrisBenedictFormulaConstants>();
        services.AddTransient<KatchMcArdleFormulaConstants>();
        services.AddTransient<MifflinStJeorFormulaConstants>();
        services.AddTransient<OwenFormulaConstants>();
        services.AddTransient<SchofieldFormulaConstants>();
        //
        // Formula Resolver
        //
        services.AddSingleton<IFormulaResolver, FormulaResolver>();
        //
        // Basal Metabolic Rate Context
        //
        services.AddSingleton<BasalMetabolicRateContext>();
        //
        // Basal Metabolic Rate Formulas
        //
        services.AddTransient<ICunninghamFormula, CunninghamFormula>();
        services.AddTransient<IHarrisBenedictFormula, HarrisBenedictFormula>();
        services.AddTransient<IKatchMcArdleFormula, KatchMcArdleFormula>();
        services.AddTransient<IMifflinStJeorFormula, MifflinStJeorFormula>();
        services.AddTransient<IOwenFormula, OwenFormula>();
        services.AddTransient<ISchofieldFormula, SchofieldFormula>();
        //
        // Daily Energy Expenditure Calculator
        //
        services.AddSingleton<IDailyEnergyExpenditureCalculator, DailyEnergyExpenditureCalculator>();
    }
}
