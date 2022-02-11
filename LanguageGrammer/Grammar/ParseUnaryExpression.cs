using LanguageGrammer.AST;

namespace LanguageGrammer.Grammar
{
    public static partial class Parser
    {
        // (- WS?)?(NumericExpression | ParenthesisExpression)
        public static Expression? ParseUnaryExpression(string text, int index)
        {
            var start = index;

            double sign = 1;

            if (text[index] == '-')
            {
                sign = -1;
                index++;
                index = SkipWhiteSpace(text, index);
            }

            var expression = ParseNumericExpression(text, index);
            if (expression!= null)
            {
                // Perform some tree reduction for numeric values
                index += expression.Length;
                expression.Length = index - start;

                ((NumericExpression)expression).Value *= sign;

                return expression;
            }

            expression = ParseParenthesisExpression(text, index);

            if (expression == null)
                return null;

            index += expression.Length;

            if (sign < 0)
                return new UnaryExpression
                {
                    Sign = sign,
                    Length = index - start,
                    Value = expression
                };

            return expression;
        }
    }
}
