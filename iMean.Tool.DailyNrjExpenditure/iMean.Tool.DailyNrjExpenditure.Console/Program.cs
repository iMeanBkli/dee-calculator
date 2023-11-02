using iMean.Tool.DailyNrjExpenditure.Bootstrap.Extensions;
using iMean.Tool.DailyNrjExpenditure.Bootstrap.Resolvers;
using iMean.Tool.DailyNrjExpenditure.Business;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.HarrisBenedict;
using iMean.Tool.DailyNrjExpenditure.Business.Strategies.MifflinStJeor;
using iMean.Tool.DailyNrjExpenditure.Entities;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddDailyEnergyExpenditure();

var serviceProvider = services.BuildServiceProvider();

var bodyInfo = new BodyInfo(80, 180, 30, Gender.Male);

var calculator = serviceProvider.GetService<IDailyEnergyExpenditureCalculator>();
var formulaResolver = serviceProvider.GetService<IFormulaResolver>();
var formula = formulaResolver.GetFormulaByName(nameof(IHarrisBenedictFormula));

var dee = calculator.Compute(bodyInfo, ActivityLevel.Sedentary, formula);

Console.WriteLine(dee.Value);