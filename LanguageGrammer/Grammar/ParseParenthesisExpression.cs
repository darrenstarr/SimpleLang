using LanguageGrammer.AST;

namespace LanguageGrammer.Grammar
{
    public static partial class Parser
    {
        // '(' WS? Expression ')' WS?
        public static Expression? ParseParenthesisExpression(string text, int index)
        {
            int start = index;

            if (text[index++] != '(')
                return null;

            index = SkipWhiteSpace(text, index);

            var expression = ParseExpression(text, index);
            if (expression == null)
                return null;

            index += expression.Length;

            if (text[index++] != ')')
                return null;

            index = SkipWhiteSpace(text, index);

            return new ParenthesisExpression
            {
                Length = index - start,
                Child = expression
            };
        }
    }
}
