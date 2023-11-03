namespace iMean.Tool.DailyNrjExpenditure.Utils.Extensions;

public static class DecimalExtensions
{
    public static decimal MultiplyBy(this decimal @decimal, decimal constant)
    {
        return decimal.Multiply(@decimal, constant);
    }

    public static decimal MultiplyBy(this int integer, decimal constant)
    {
        return decimal.Multiply(integer, constant);
    }
}
