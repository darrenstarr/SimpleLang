namespace LanguageGrammer.AST
{
    public enum BinaryExpressionType
    {
        Unknown,
        Additive,
        Subtractive,
        Multiplicative,
        Division
    }

    public class BinaryExpression : Expression
    {
        public BinaryExpressionType ExpressionType;
        public Expression? Right;

        public override string TokenType => ExpressionType.ToString();

        public override string ToString()
        {
            return
                (
                ExpressionType == BinaryExpressionType.Additive ? " + " :
                ExpressionType == BinaryExpressionType.Subtractive ? " - " :
                ExpressionType == BinaryExpressionType.Multiplicative ? " * " :
                ExpressionType == BinaryExpressionType.Division ? " / " :
                String.Empty
                ) + ((Right == null) ? "" : Right.ToString());
        }
    }
}
