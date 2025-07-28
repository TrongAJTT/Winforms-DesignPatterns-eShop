namespace _3S_eShop.PatternDistinctive.Strategy.CharacterValidator
{
    public class SpecialCharacterOnlyStrategy : BaseCharacterValidationStrategy
    {
        private readonly string _allowedSpecialChars;

        public SpecialCharacterOnlyStrategy(string allowedSpecialChars = "@#-=+()*&^!")
        {
            _allowedSpecialChars = allowedSpecialChars;
        }

        public override bool IsValidCharacter(char inputChar)
        {
            return _allowedSpecialChars.Contains(inputChar.ToString());
        }
    }
}
