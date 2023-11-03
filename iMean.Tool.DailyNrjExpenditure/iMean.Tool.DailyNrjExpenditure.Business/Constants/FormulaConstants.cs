namespace iMean.Tool.DailyNrjExpenditure.Business.Constants
{
    public abstract class FormulaConstants
    {
        public const string BmrBaseConstantName = "BmrBaseConstant";
        public const string HeightConstantName = "BmrHeightConstant";
        public const string WeightConstantName = "BmrWeightConstant";
        public const string AgeConstantName = "BmrAgeConstant";

        protected Dictionary<string, Constant<decimal>> _formulaConstants;

        protected FormulaConstants() 
        {
            _formulaConstants = new Dictionary<string, Constant<decimal>>();
            InitializeConstants();
        }

        public Constant<decimal> GetConstantByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));

            if (_formulaConstants.TryGetValue(name, out var constant))
                return constant;

            throw new KeyNotFoundException($"No constant found for '{name}'");
        }

        protected abstract void InitializeConstants();
    }
}
