namespace iMean.Tool.DailyNrjExpenditure.Entities;

public class EnergyExpenditure : Measure<decimal>
{
    private static Dictionary<EnergyExpenditureUnit, string> EnergyExpenditureUnits = new Dictionary<EnergyExpenditureUnit, string>
    {
        { EnergyExpenditureUnit.Kcal, "kcal" },
        { EnergyExpenditureUnit.KcalPerDay, "kcal/day" },
    };

    public EnergyExpenditure(decimal value)
        : this(value, EnergyExpenditureUnit.KcalPerDay) { }

    public EnergyExpenditure(decimal value, EnergyExpenditureUnit unit)
        : base(value, EnergyExpenditureUnits[unit]) { }
}
