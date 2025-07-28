namespace _3S_eShop.PatternDistinctive.Strategy.CharacterValidator
{
    public class AlphabetOnlyCharacterStrategy : BaseCharacterValidationStrategy
    {
        public override bool IsValidCharacter(char inputChar)
        {
            return char.IsLetter(inputChar);
        }
    }
}
