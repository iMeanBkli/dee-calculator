namespace iMean.Tool.DailyNrjExpenditure.Entities.Measurement;

public class Height : Measure<decimal>
{
    private const decimal MinHeight = 54.6m;
    private const decimal MaxHeight = 272m;

    private static Dictionary<HeightUnit, string> LengthUnits = new Dictionary<HeightUnit, string>
    {
        { HeightUnit.Centimeter, "cm" },
        { HeightUnit.Meter, "m" },
    };

    public Height(decimal value)
        : this(value, HeightUnit.Centimeter)
    {
    }

    public Height(decimal value, HeightUnit unit)
        : base(LengthUnits[unit])
    {
        if (value < MinHeight)
            throw new ArgumentException($"", nameof(value));

        if (value > MaxHeight)
            throw new ArgumentException($"", nameof(value));

        Value = value;
    }

    public decimal ToMeter()
    {
        return decimal.Divide(Value, 100m);
    }
}
