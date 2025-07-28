namespace _3S_eShop.PatternDistinctive.Strategy.CharacterValidator
{
    public class NumberOnlyCharacterStrategy : BaseCharacterValidationStrategy
    {
        private readonly bool _allowNegative;

        public NumberOnlyCharacterStrategy(bool allowNegative = false)
        {
            _allowNegative = allowNegative;
        }

        public override bool IsValidCharacter(char inputChar)
        {
            bool processNegative = _allowNegative ? inputChar == '-' : false;
            return processNegative || char.IsDigit(inputChar);
        }
    }
}
