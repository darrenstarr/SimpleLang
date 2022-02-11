using LanguageGrammer.AST;

namespace LanguageGrammer.Grammar
{
    public static partial class Parser
    {
        public static Token? Parse(string text, int index = 0)
        {
            index = SkipWhiteSpace(text, index);

            var expression = ParseExpression(text, index);
            if (expression != null)
            {
                //index += expression.Length;
                return expression;
            }

            return null;
        }
    }
}
