using LanguageGrammer.AST;

namespace LanguageGrammer.Grammar
{
    public static partial class Parser
    {
        public static Expression? ParseNumericExpression(string text, int index)
        {
            var start = index;

            var integerDigits = ParseDigits(text, index);
            if (integerDigits == String.Empty)
                return null;

            index += integerDigits.Length;

            string fractionalDigits = "0";
            if (index < text.Length && text[index] == '.')
            {
                index++;
                fractionalDigits = ParseDigits(text, index);
                if (fractionalDigits == String.Empty)
                    return null;

                index += fractionalDigits.Length;
            }

            index = SkipWhiteSpace(text, index);

            return new NumericExpression
            {
                Length = index - start,
                Value =
                    (
                    Convert.ToDouble(integerDigits) +
                    Convert.ToDouble(fractionalDigits) / Math.Pow(10, fractionalDigits.Length)
                    )
            };
        }
    }
}
