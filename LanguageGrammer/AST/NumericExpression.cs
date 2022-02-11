namespace LanguageGrammer.AST
{
    public class NumericExpression : Expression
    {
        public double Value = 0.0;

        public override string TokenType => "Number";

        public override string ToString() => Value.ToString();
    }
}
