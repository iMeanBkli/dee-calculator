using iMean.Tool.DailyNrjExpenditure.Bootstrap.Extensions;
using iMean.Tool.DailyNrjExpenditure.Bootstrap.Resolvers;
using iMean.Tool.DailyNrjExpenditure.Business;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.MifflinStJeor;
using iMean.Tool.DailyNrjExpenditure.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var host = CreateHostBuilder().Build();

var serviceProvider = host.Services;

var bodyInfo = new BodyInfo(76, 183, 31, Gender.Male);

var calculator = serviceProvider.GetService<IDailyEnergyExpenditureCalculator>();
var formulaResolver = serviceProvider.GetService<IFormulaResolver>();
var formula = formulaResolver.GetFormulaByName(nameof(IMifflinStJeorFormula));

var dee = calculator.Compute(bodyInfo, ActivityLevel.ModeratelyActive, formula);

Console.WriteLine($"Résultat : {dee.Value} {dee.Unit}");

static IHostBuilder CreateHostBuilder()
{
    return Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
            services.AddDailyEnergyExpenditure();
        });
}