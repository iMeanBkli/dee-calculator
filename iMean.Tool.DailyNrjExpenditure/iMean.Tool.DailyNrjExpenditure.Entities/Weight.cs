namespace iMean.Tool.DailyNrjExpenditure.Entities;

public class Weight : Measure<decimal>
{
    private const decimal MinWeight = 25m;
    private const decimal MaxWeight = 595m;

    private static Dictionary<WeightUnit, string> WeightUnits = new Dictionary<WeightUnit, string>()
    {
        { WeightUnit.Kilogram, "kg" }
    };

    public Weight(decimal value)
        : this(value, WeightUnit.Kilogram)
    {
    }

    public Weight(decimal value, WeightUnit unit)
        : base(WeightUnits[unit])
    {
        if (value < MinWeight)
            throw new ArgumentException($"", nameof(value));

        if (value > MaxWeight)
            throw new ArgumentException($"", nameof(value));

        Value = value;
    }
}
