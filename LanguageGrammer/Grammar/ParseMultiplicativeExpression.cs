using LanguageGrammer.AST;

namespace LanguageGrammer.Grammar
{
    public static partial class Parser
    {
        // UnaryExpression WS? [*/] WS? (UnaryExpression WS?)*
        public static Expression? ParseMultiplicativeExpression(string text, int index)
        {
            var start = index;

            var firstExpression = ParseUnaryExpression(text, index);
            if (firstExpression == null)
                return null;

            index += firstExpression.Length;

            if (index >= text.Length)
                return firstExpression;

            var Terms = new List<BinaryExpression>();

            while (index < text.Length && (text[index] == '*' || text[index] == '/'))
            {
                var termStart = index;

                index++;
                index = SkipWhiteSpace(text, index);

                var nextTerm = ParseUnaryExpression(text, index);
                if (nextTerm == null)
                    return null;

                index += nextTerm.Length;

                index = SkipWhiteSpace(text, index);

                var length = index - termStart;

                Terms.Add(
                    new BinaryExpression
                    {
                        Length = length,
                        ExpressionType = text[termStart] == '*' ? BinaryExpressionType.Multiplicative : BinaryExpressionType.Division,
                        Right = nextTerm
                    });
            }

            if (Terms.Count == 0)
                return firstExpression;

            Terms.Insert(0, new BinaryExpression
            {
                ExpressionType = BinaryExpressionType.Additive,
                Right = firstExpression
            });

            return new ArithmeticExpression
            {
                Length = index - start,
                Terms = Terms
            };
        }
    }
}
