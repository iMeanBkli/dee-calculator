using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Constants;

public class Constant<T>
    where T : struct
{
    private readonly Dictionary<Gender, T> _constants;

    public Constant()
    {
        _constants = new Dictionary<Gender, T>();
    }

    public T GetValueForGender(Gender gender)
    {
        if (_constants.TryGetValue(gender, out T value)) 
            return value;

        throw new KeyNotFoundException($"No constant value found for gender '{ gender }'");
    }

    public T AddOrUpdateValue(Gender gender, T value)
    {
        if (_constants.TryGetValue(gender, out var constant))
        {
            _constants[gender] = value;
            return _constants[gender];
        }

        _constants.Add(gender, value);
        return value;
    }
}
