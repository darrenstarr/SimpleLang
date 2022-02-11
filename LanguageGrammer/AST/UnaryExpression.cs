namespace LanguageGrammer.AST
{
    public class UnaryExpression : Expression
    {
        public Expression? Value;

        public double Sign;

        public override string ToString() => (Sign < 0 ? "-" : "") + ((Value == null) ? "null" : Value.ToString());
    }
}
