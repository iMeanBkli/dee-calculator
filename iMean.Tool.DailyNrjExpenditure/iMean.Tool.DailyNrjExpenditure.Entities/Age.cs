namespace iMean.Tool.DailyNrjExpenditure.Entities;

public class Age : Measure<int>
{
    private const int MinAge = 1;
    private const int MaxAge = 122;

    public Age(int value)
        : base("years")
    {
        if (value < MinAge)
            throw new ArgumentException($"", nameof(value));

        if (value > MaxAge)
            throw new ArgumentException($"", nameof(value));

        Value = value;
    }
}
