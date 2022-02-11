using LanguageGrammer.AST;

namespace LanguageGrammer.Grammar
{
    public static partial class Parser
    {
        public static Expression? ParseExpression(string text, int index)
        {
            var expression = ParseAdditiveExpression(text, index);
            if (expression != null)
                return expression;

            return null;
        }
    }
}
