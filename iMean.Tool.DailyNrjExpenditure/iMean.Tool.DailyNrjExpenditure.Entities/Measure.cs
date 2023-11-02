namespace iMean.Tool.DailyNrjExpenditure.Entities;

public abstract class Measure<TValue> 
    where TValue : struct
{
    protected Measure(string unit)
    {
        if (string.IsNullOrWhiteSpace(unit))
            throw new ArgumentNullException(nameof(unit));

        Unit = unit;
    }

    protected Measure(TValue value, string unit)
        : this(unit)
    {
        Value = value;
    }

    public TValue Value { get; protected init; }

    public string Unit { get; }
}
