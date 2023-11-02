using iMean.Tool.DailyNrjExpenditure.Entities;

namespace iMean.Tool.DailyNrjExpenditure.Business.Strategies.Provider;

public sealed class FormulaProvider
{
    #region Children and Adolescents formulas

    public static ISchofieldFormula SchofieldFormula { get; }
    public static IWorldHealthOrganizationFormula WorldHealthOrganizationFormula { get; }

    #endregion

    #region Adults formulas

    public static IHarrisBenedictFormula HarrisBenedictFormula { get; }
    public static IKatchMcArdleFormula KatchMcArdleFormula { get; }
    public static IMifflinStJeorFormula MifflinStJeorFormula { get; }
    public static IMifflinStJeorRevisedFormula MifflinStJeorRevisedFormula { get; }
    public static ICunninghamFormula CunninghamFormula { get; }
    public static IOwenFormula OwenFormula { get; }

    #endregion

    private const int ChildrenAndAdolescentsMaxAge = 18;

    public static IFormula GetDefaultFormula(BodyInfo bodyInfo)
    {
        if (bodyInfo == null)
            throw new ArgumentNullException(nameof(bodyInfo));

        return bodyInfo.Age.Value <= ChildrenAndAdolescentsMaxAge ? WorldHealthOrganizationFormula : MifflinStJeorFormula;
    }

}
