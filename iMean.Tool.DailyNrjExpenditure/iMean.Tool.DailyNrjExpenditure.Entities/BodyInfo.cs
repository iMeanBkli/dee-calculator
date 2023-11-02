namespace iMean.Tool.DailyNrjExpenditure.Entities;

public class BodyInfo
{
    public BodyInfo(decimal weight, decimal height, int age, Gender gender)
    {
        Weight = new Weight(weight);
        Height = new Height(height);
        Age = new Age(age);
        Gender = gender;
    }

    public string? Name { get; init; }

    public Weight Weight { get; }

    public Height Height { get; }

    public Age Age { get; }

    public Gender Gender { get; init; }
}
