namespace iMean.Tool.DailyNrjExpenditure.Entities;

public enum ActivityLevel
{
    Sedentary = 1200,
    LightlyActive = 1375,
    ModeratelyActive = 1550,
    VeryActive = 1725,
    ExtremelyActive = 1900,
}

public struct ActivityFactor
{
    private const int Precision = 1000;

    public ActivityLevel ActivityLevel { get; init; }

    public decimal Value => decimal.Divide((int)ActivityLevel, Precision);

    public static implicit operator ActivityFactor(ActivityLevel activity) => new ActivityFactor { ActivityLevel = activity };
}
